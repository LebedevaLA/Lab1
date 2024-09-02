using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form2 : Form
    {
        string number;
        string name;
        DateTime date;
        int role = 0;
        public Form2(int x)
        {
            InitializeComponent();
            OK.DialogResult = DialogResult.OK;
            Cancel.DialogResult = DialogResult.Cancel;
            AcceptButton = OK;
            CancelButton = Cancel;

            if (x == 2)
            {
                inputNumberCard.Enabled = false;
                inputDateTime.Enabled = false;
            }
        }

        public DateTime GetInputDateTime()
        {
            return inputDateTime.Value;
        }

        public void SetInputDateTime(DateTime val)
        {
            inputDateTime.Value = val;
        }

        public Person inputData()
        {
            number = inputNumberCard.Text;
            name = inputName.Text;
            date = inputDateTime.Value;
            if (number.Length != 5) throw new Exception("Некорректный номер карты!");
            else if (name == "") throw new Exception("Имя не введено!");
            else if (new Person().calcAge(date) < 18) throw new Exception("Некорретная дата рождения! Пользователь должен быть старше 18 лет.");
            else
            {
                Person pers = new Person(Int32.Parse(number), name, date);
                return pers;
            }
        }
        
        public void changePerson(ref List<Person> people, int index)
        {
            if (role == 0 && inputName.Text != "")
            {
                people[index].Name = inputName.Text;
                _ = MessageBox.Show("Запись изменена!");
            }
            else if (role == 0 && inputName.Text == "")
            {
                throw new Exception("Вы не ввели имя!");
            }
            else if (role == 1 && inputNumberCard.Text.Length != 0 && inputNumberCard.Text.Length != 5)
            {
                throw new Exception("Введён некорректный номер карты,длина номера карты должна равняться 5!");
            }
            else if (role == 1 && new Person().calcAge(inputDateTime.Value) < 18)
            {
                throw new Exception("Владелец карты должен быть старше 18 лет!");
            }
            else
            {
                if (inputName.Text != "") people[index].Name = inputName.Text;
                people[index].Bithday = inputDateTime.Value;
                if (inputNumberCard.Text.Length != 0) people[index].CardNumber = int.Parse(inputNumberCard.Text);
                _ = MessageBox.Show("Запись изменена!");
            }
        }
        

        private void Form2_KeyDown_login(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.Control && e.KeyCode == Keys.L)
            {
                Form3 log = new Form3();
                if (log.ShowDialog() == DialogResult.OK && log.Getrole() == 1)
                {
                    this.BackColor = Color.LightGreen;
                    inputDateTime.BackColor = Color.LightGray;
                    inputName.BackColor = Color.LightGray;
                    inputNumberCard.BackColor = Color.LightGray;
                    OK.BackColor = Color.LightSkyBlue;
                    Cancel.BackColor = Color.LightCoral;

                    inputNumberCard.Enabled = true;
                    inputDateTime.Enabled = true;
                    role = 1;
                }

            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        List<Person> people;//поле класса

        public Form1()
        {
            people = new List<Person>();//инициализация 
            InitializeComponent();
        }


        private void createNewRecord_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2(1);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Person new_person = dialog.inputData();
                    people.Add(new_person);
                    _ = MessageBox.Show("Запись добавлена!");
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message);
                }
            }
            refresh();
        }


        private void changeRecord_Click(object sender, EventArgs e)
        {
            int index = listPeople.SelectedIndex;
            if (index == -1)
            {
                _ = MessageBox.Show("Вы не выбрали запись!");
            }
            else
            {
                Form2 dialog2 = new Form2(2);
                dialog2.SetInputDateTime(people[index].Bithday); // чтобы дефолтное значение даты сразу было актуальным
                DialogResult result = dialog2.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try {
                        dialog2.changePerson(ref people, listPeople.SelectedIndex);
                    }
                    catch (Exception ex){
                        _ = MessageBox.Show(ex.Message);
                    }
                    refresh();
                }
            }
            return;     
        }


        private void deleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK && listPeople.SelectedIndex != -1)
            {
                people.RemoveAt(listPeople.SelectedIndex);
                refresh();
            }
            else if (listPeople.SelectedIndex == -1)
            {
                _ = MessageBox.Show("Вы не выбрали запись!");
            }
        }


        private void refresh()
        {
            listPeople.Items.Clear();
            for (int i = 0; i < people.Count(); ++i)
            {
                listPeople.Items.Add(string.Format("{0} - {1} - {2}",
                    people[i].Name,
                    people[i].calcAge(people[i].Bithday),
                    people[i].CardNumber)
                );
            }
        }
    }
}

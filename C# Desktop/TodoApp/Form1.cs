using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            String taskName = taskTextBox.Text;

            if (taskName == "")
            {
                MessageBox.Show("Type a task name to add it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            checkedTodoList.Items.Add(taskName);

            taskTextBox.Text = "";
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            List<String> TasksNameToDelete = new List<string>();

            Int32 checkedItemsCount = checkedTodoList.CheckedItems.Count;

            if (checkedItemsCount == 0)
            {
                MessageBox.Show("Select at least one item to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string itemName in checkedTodoList.CheckedItems)
            {
                TasksNameToDelete.Add(itemName);
            }

            String Message = "Do you really want to delete these tasks: " + String.Join(", ", TasksNameToDelete) + " ?";

            DialogResult dialogResult = MessageBox.Show(Message, "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = checkedTodoList.Items.Count - 1; i >= 0; i--)
                {
                    if (checkedTodoList.GetItemChecked(i))
                    {
                        checkedTodoList.Items.Remove(checkedTodoList.Items[i]);
                    }

                }
            }
        }

        private void btnClearListClick_Click(object sender, EventArgs e)
        {
            String Message = "Do you really want to delete all tasks ?";

            DialogResult dialogResult = MessageBox.Show(Message, "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                checkedTodoList.Items.Clear();
            }
        }
    }
}

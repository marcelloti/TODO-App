
namespace TodoApp
{
    partial class mainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.appTitle = new System.Windows.Forms.Label();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedTodoList = new System.Windows.Forms.CheckedListBox();
            this.btnClearListClick = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // appTitle
            // 
            this.appTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.appTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitle.Location = new System.Drawing.Point(0, 0);
            this.appTitle.Name = "appTitle";
            this.appTitle.Size = new System.Drawing.Size(501, 144);
            this.appTitle.TabIndex = 0;
            this.appTitle.Text = "TODO App";
            this.appTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(12, 175);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(395, 20);
            this.taskTextBox.TabIndex = 1;
            this.taskTextBox.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TaskName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedTodoList);
            this.groupBox1.Location = new System.Drawing.Point(12, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 227);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TodoListBox";
            // 
            // checkedTodoList
            // 
            this.checkedTodoList.FormattingEnabled = true;
            this.checkedTodoList.Location = new System.Drawing.Point(15, 29);
            this.checkedTodoList.Name = "checkedTodoList";
            this.checkedTodoList.Size = new System.Drawing.Size(360, 154);
            this.checkedTodoList.TabIndex = 6;
            // 
            // btnClearListClick
            // 
            this.btnClearListClick.Image = global::TodoApp.Properties.Resources.clear16;
            this.btnClearListClick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearListClick.Location = new System.Drawing.Point(413, 399);
            this.btnClearListClick.Name = "btnClearListClick";
            this.btnClearListClick.Size = new System.Drawing.Size(75, 39);
            this.btnClearListClick.TabIndex = 8;
            this.btnClearListClick.Text = "CLEAR";
            this.btnClearListClick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearListClick.UseVisualStyleBackColor = true;
            this.btnClearListClick.Click += new System.EventHandler(this.btnClearListClick_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Image = global::TodoApp.Properties.Resources.remove;
            this.btnDeleteTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTask.Location = new System.Drawing.Point(413, 343);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteTask.TabIndex = 7;
            this.btnDeleteTask.Text = "DELETE";
            this.btnDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Image = global::TodoApp.Properties.Resources.add;
            this.btnAddTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.Location = new System.Drawing.Point(413, 165);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 39);
            this.btnAddTask.TabIndex = 4;
            this.btnAddTask.Text = "ADD";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TodoApp.Properties.Resources.TodoApp_List;
            this.pictureBox1.Location = new System.Drawing.Point(36, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 96);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.btnClearListClick);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.appTitle);
            this.Name = "mainForm";
            this.Text = "TODO App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appTitle;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedTodoList;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnClearListClick;
    }
}


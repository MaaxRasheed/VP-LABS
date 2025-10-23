namespace ToDoApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtTitle = new TextBox();
            txtDescription = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            dtpDueDate = new DateTimePicker();
            label3 = new Label();
            lstTasks = new ListBox();
            label4 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnMarkCompleted = new Button();
            cmbFilter = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(165, 84);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(189, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(165, 152);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(189, 96);
            txtDescription.TabIndex = 1;
            txtDescription.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(44, 84);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(44, 152);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(165, 302);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(189, 23);
            dtpDueDate.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(44, 304);
            label3.Name = "label3";
            label3.Size = new Size(81, 21);
            label3.TabIndex = 5;
            label3.Text = "Due Date";
            // 
            // lstTasks
            // 
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 15;
            lstTasks.Location = new Point(500, 84);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(161, 109);
            lstTasks.TabIndex = 6;
            lstTasks.SelectedIndexChanged += lstTasks_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(407, 82);
            label4.Name = "label4";
            label4.Size = new Size(67, 21);
            label4.TabIndex = 7;
            label4.Text = "Display";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Font = new Font("Segoe UI", 11F);
            btnAdd.Location = new Point(451, 228);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 36);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(0, 192, 0);
            btnUpdate.Font = new Font("Segoe UI", 11F);
            btnUpdate.Location = new Point(547, 230);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Arial", 11F);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(500, 284);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 38);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMarkCompleted
            // 
            btnMarkCompleted.BackColor = SystemColors.ActiveCaptionText;
            btnMarkCompleted.Font = new Font("Arial", 11F, FontStyle.Bold);
            btnMarkCompleted.ForeColor = SystemColors.ControlLightLight;
            btnMarkCompleted.Location = new Point(468, 350);
            btnMarkCompleted.Name = "btnMarkCompleted";
            btnMarkCompleted.Size = new Size(145, 44);
            btnMarkCompleted.TabIndex = 11;
            btnMarkCompleted.Text = "Marked Complete";
            btnMarkCompleted.UseVisualStyleBackColor = false;
            btnMarkCompleted.Click += btnMarkCompleted_Click;
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(642, 250);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(121, 23);
            cmbFilter.TabIndex = 12;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(642, 214);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 13;
            label5.Text = "Filter";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(cmbFilter);
            Controls.Add(btnMarkCompleted);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(lstTasks);
            Controls.Add(label3);
            Controls.Add(dtpDueDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private RichTextBox txtDescription;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDueDate;
        private Label label3;
        private ListBox lstTasks;
        private Label label4;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnMarkCompleted;
        private ComboBox cmbFilter;
        private Label label5;
    }
}

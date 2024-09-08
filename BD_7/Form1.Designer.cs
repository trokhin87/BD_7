namespace BD_7
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
            table = new TabControl();
            Абонент = new TabPage();
            Библиотека = new TabPage();
            Выдача = new TabPage();
            книга = new TabPage();
            Сотрудник = new TabPage();
            хранилище = new TabPage();
            Добавить = new Button();
            Обновить = new Button();
            Удалить = new Button();
            Выход = new Button();
            table.SuspendLayout();
            SuspendLayout();
            // 
            // table
            // 
            table.Controls.Add(Абонент);
            table.Controls.Add(Библиотека);
            table.Controls.Add(Выдача);
            table.Controls.Add(книга);
            table.Controls.Add(Сотрудник);
            table.Controls.Add(хранилище);
            table.Location = new Point(0, 0);
            table.Name = "table";
            table.SelectedIndex = 0;
            table.Size = new Size(398, 290);
            table.TabIndex = 0;
            // 
            // Абонент
            // 
            Абонент.BackColor = Color.AliceBlue;
            Абонент.Location = new Point(4, 24);
            Абонент.Name = "Абонент";
            Абонент.Padding = new Padding(3);
            Абонент.Size = new Size(390, 262);
            Абонент.TabIndex = 0;
            Абонент.Text = "Абонент";
            Абонент.Click += Абонент_Click;
            // 
            // Библиотека
            // 
            Библиотека.Location = new Point(4, 24);
            Библиотека.Name = "Библиотека";
            Библиотека.Padding = new Padding(3);
            Библиотека.Size = new Size(390, 262);
            Библиотека.TabIndex = 1;
            Библиотека.Text = "Библиотека";
            Библиотека.UseVisualStyleBackColor = true;
            Библиотека.Click += Библиотека_Click;
            // 
            // Выдача
            // 
            Выдача.Location = new Point(4, 24);
            Выдача.Name = "Выдача";
            Выдача.Padding = new Padding(3);
            Выдача.Size = new Size(390, 262);
            Выдача.TabIndex = 2;
            Выдача.Text = "Выдача";
            Выдача.UseVisualStyleBackColor = true;
            // 
            // книга
            // 
            книга.Location = new Point(4, 24);
            книга.Name = "книга";
            книга.Padding = new Padding(3);
            книга.Size = new Size(390, 262);
            книга.TabIndex = 3;
            книга.Text = "книга";
            книга.UseVisualStyleBackColor = true;
            книга.Click += книга_Click;
            // 
            // Сотрудник
            // 
            Сотрудник.Location = new Point(4, 24);
            Сотрудник.Name = "Сотрудник";
            Сотрудник.Padding = new Padding(3);
            Сотрудник.Size = new Size(390, 262);
            Сотрудник.TabIndex = 4;
            Сотрудник.Text = "Сотрудник";
            Сотрудник.UseVisualStyleBackColor = true;
            Сотрудник.Click += Сотрудник_Click;
            // 
            // хранилище
            // 
            хранилище.Location = new Point(4, 24);
            хранилище.Name = "хранилище";
            хранилище.Padding = new Padding(3);
            хранилище.Size = new Size(390, 262);
            хранилище.TabIndex = 5;
            хранилище.Text = "хранилище";
            хранилище.UseVisualStyleBackColor = true;
            хранилище.Click += хранилище_Click;
            // 
            // Добавить
            // 
            Добавить.Location = new Point(538, 90);
            Добавить.Name = "Добавить";
            Добавить.Size = new Size(75, 23);
            Добавить.TabIndex = 1;
            Добавить.Text = "Добавить";
            Добавить.UseVisualStyleBackColor = true;
            Добавить.Click += Добавить_Click;
            // 
            // Обновить
            // 
            Обновить.Location = new Point(538, 160);
            Обновить.Name = "Обновить";
            Обновить.Size = new Size(75, 23);
            Обновить.TabIndex = 2;
            Обновить.Text = "Обновить";
            Обновить.UseVisualStyleBackColor = true;
            Обновить.Click += Обновить_Click;
            // 
            // Удалить
            // 
            Удалить.Location = new Point(538, 223);
            Удалить.Name = "Удалить";
            Удалить.Size = new Size(75, 23);
            Удалить.TabIndex = 3;
            Удалить.Text = "Удалить";
            Удалить.UseVisualStyleBackColor = true;
            Удалить.Click += Удалить_Click;
            // 
            // Выход
            // 
            Выход.Location = new Point(724, 12);
            Выход.Name = "Выход";
            Выход.Size = new Size(75, 23);
            Выход.TabIndex = 4;
            Выход.Text = "Выход";
            Выход.UseVisualStyleBackColor = true;
            Выход.Click += Выход_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Выход);
            Controls.Add(Удалить);
            Controls.Add(Обновить);
            Controls.Add(Добавить);
            Controls.Add(table);
            Name = "Form1";
            Text = "Form1";
            table.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl table;
        private TabPage Абонент;
        private TabPage Библиотека;
        private TabPage Выдача;
        private TabPage книга;
        private TabPage Сотрудник;
        private TabPage хранилище;
        private Button Добавить;
        private Button Обновить;
        private Button Удалить;
        private Button Выход;
    }
}

namespace WindowsFormsApplication1
{
    partial class DMS
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.box = new System.Windows.Forms.TabControl();
            this.Pdel = new System.Windows.Forms.TabPage();
            this.CBdel = new System.Windows.Forms.ComboBox();
            this.Del = new System.Windows.Forms.Button();
            this.Pd = new System.Windows.Forms.TabPage();
            this.Bupd = new System.Windows.Forms.Button();
            this.CBdob12 = new System.Windows.Forms.ComboBox();
            this.CBdob11 = new System.Windows.Forms.ComboBox();
            this.CBdob10 = new System.Windows.Forms.ComboBox();
            this.CBdob9 = new System.Windows.Forms.ComboBox();
            this.CBdob8 = new System.Windows.Forms.ComboBox();
            this.CBdob4 = new System.Windows.Forms.ComboBox();
            this.CBdob7 = new System.Windows.Forms.ComboBox();
            this.CBdob3 = new System.Windows.Forms.ComboBox();
            this.CBdob6 = new System.Windows.Forms.ComboBox();
            this.CBdob2 = new System.Windows.Forms.ComboBox();
            this.CBdob5 = new System.Windows.Forms.ComboBox();
            this.CBdob1 = new System.Windows.Forms.ComboBox();
            this.Bdob = new System.Windows.Forms.Button();
            this.Otch = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BOtch = new System.Windows.Forms.Button();
            this.Totch = new System.Windows.Forms.TextBox();
            this.ToUsers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокАудиторийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокГруппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчет1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыГруппToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыАудиторийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.базыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.box.SuspendLayout();
            this.Pdel.SuspendLayout();
            this.Pd.SuspendLayout();
            this.Otch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv1.Location = new System.Drawing.Point(1, 30);
            this.dgv1.Margin = new System.Windows.Forms.Padding(0);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.Size = new System.Drawing.Size(1738, 380);
            this.dgv1.TabIndex = 5;
            this.dgv1.TabStop = false;
            // 
            // box
            // 
            this.box.Controls.Add(this.Pdel);
            this.box.Controls.Add(this.Pd);
            this.box.Controls.Add(this.Otch);
            this.box.Location = new System.Drawing.Point(160, 410);
            this.box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box.Name = "box";
            this.box.SelectedIndex = 0;
            this.box.Size = new System.Drawing.Size(1075, 160);
            this.box.TabIndex = 5;
            // 
            // Pdel
            // 
            this.Pdel.Controls.Add(this.CBdel);
            this.Pdel.Controls.Add(this.Del);
            this.Pdel.Location = new System.Drawing.Point(4, 25);
            this.Pdel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pdel.Name = "Pdel";
            this.Pdel.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pdel.Size = new System.Drawing.Size(1067, 131);
            this.Pdel.TabIndex = 1;
            this.Pdel.Text = "Удаление";
            this.Pdel.UseVisualStyleBackColor = true;
            // 
            // CBdel
            // 
            this.CBdel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBdel.FormattingEnabled = true;
            this.CBdel.Location = new System.Drawing.Point(337, 62);
            this.CBdel.Margin = new System.Windows.Forms.Padding(4);
            this.CBdel.Name = "CBdel";
            this.CBdel.Size = new System.Drawing.Size(199, 24);
            this.CBdel.TabIndex = 0;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(603, 58);
            this.Del.Margin = new System.Windows.Forms.Padding(4);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(200, 31);
            this.Del.TabIndex = 1;
            this.Del.Text = "Удалить";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Pd
            // 
            this.Pd.Controls.Add(this.Bupd);
            this.Pd.Controls.Add(this.CBdob12);
            this.Pd.Controls.Add(this.CBdob11);
            this.Pd.Controls.Add(this.CBdob10);
            this.Pd.Controls.Add(this.CBdob9);
            this.Pd.Controls.Add(this.CBdob8);
            this.Pd.Controls.Add(this.CBdob4);
            this.Pd.Controls.Add(this.CBdob7);
            this.Pd.Controls.Add(this.CBdob3);
            this.Pd.Controls.Add(this.CBdob6);
            this.Pd.Controls.Add(this.CBdob2);
            this.Pd.Controls.Add(this.CBdob5);
            this.Pd.Controls.Add(this.CBdob1);
            this.Pd.Controls.Add(this.Bdob);
            this.Pd.Location = new System.Drawing.Point(4, 25);
            this.Pd.Margin = new System.Windows.Forms.Padding(4);
            this.Pd.Name = "Pd";
            this.Pd.Padding = new System.Windows.Forms.Padding(4);
            this.Pd.Size = new System.Drawing.Size(1067, 131);
            this.Pd.TabIndex = 2;
            this.Pd.Text = "Добавление";
            this.Pd.UseVisualStyleBackColor = true;
            // 
            // Bupd
            // 
            this.Bupd.Location = new System.Drawing.Point(852, 48);
            this.Bupd.Margin = new System.Windows.Forms.Padding(4);
            this.Bupd.Name = "Bupd";
            this.Bupd.Size = new System.Drawing.Size(204, 31);
            this.Bupd.TabIndex = 31;
            this.Bupd.Text = "Редактировать";
            this.Bupd.UseVisualStyleBackColor = true;
            this.Bupd.Click += new System.EventHandler(this.Bupd_Click);
            // 
            // CBdob12
            // 
            this.CBdob12.FormattingEnabled = true;
            this.CBdob12.Location = new System.Drawing.Point(649, 85);
            this.CBdob12.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob12.Name = "CBdob12";
            this.CBdob12.Size = new System.Drawing.Size(195, 24);
            this.CBdob12.TabIndex = 30;
            // 
            // CBdob11
            // 
            this.CBdob11.FormattingEnabled = true;
            this.CBdob11.Location = new System.Drawing.Point(447, 85);
            this.CBdob11.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob11.Name = "CBdob11";
            this.CBdob11.Size = new System.Drawing.Size(195, 24);
            this.CBdob11.TabIndex = 29;
            // 
            // CBdob10
            // 
            this.CBdob10.FormattingEnabled = true;
            this.CBdob10.Location = new System.Drawing.Point(243, 85);
            this.CBdob10.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob10.Name = "CBdob10";
            this.CBdob10.Size = new System.Drawing.Size(195, 24);
            this.CBdob10.TabIndex = 28;
            // 
            // CBdob9
            // 
            this.CBdob9.FormattingEnabled = true;
            this.CBdob9.Location = new System.Drawing.Point(39, 85);
            this.CBdob9.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob9.Name = "CBdob9";
            this.CBdob9.Size = new System.Drawing.Size(195, 24);
            this.CBdob9.TabIndex = 27;
            // 
            // CBdob8
            // 
            this.CBdob8.FormattingEnabled = true;
            this.CBdob8.Location = new System.Drawing.Point(649, 52);
            this.CBdob8.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob8.Name = "CBdob8";
            this.CBdob8.Size = new System.Drawing.Size(195, 24);
            this.CBdob8.TabIndex = 26;
            // 
            // CBdob4
            // 
            this.CBdob4.FormattingEnabled = true;
            this.CBdob4.Location = new System.Drawing.Point(649, 20);
            this.CBdob4.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob4.Name = "CBdob4";
            this.CBdob4.Size = new System.Drawing.Size(195, 24);
            this.CBdob4.TabIndex = 25;
            // 
            // CBdob7
            // 
            this.CBdob7.FormattingEnabled = true;
            this.CBdob7.Location = new System.Drawing.Point(445, 52);
            this.CBdob7.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob7.Name = "CBdob7";
            this.CBdob7.Size = new System.Drawing.Size(195, 24);
            this.CBdob7.TabIndex = 24;
            // 
            // CBdob3
            // 
            this.CBdob3.FormattingEnabled = true;
            this.CBdob3.Location = new System.Drawing.Point(445, 20);
            this.CBdob3.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob3.Name = "CBdob3";
            this.CBdob3.Size = new System.Drawing.Size(195, 24);
            this.CBdob3.TabIndex = 23;
            // 
            // CBdob6
            // 
            this.CBdob6.FormattingEnabled = true;
            this.CBdob6.Location = new System.Drawing.Point(243, 52);
            this.CBdob6.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob6.Name = "CBdob6";
            this.CBdob6.Size = new System.Drawing.Size(195, 24);
            this.CBdob6.TabIndex = 22;
            // 
            // CBdob2
            // 
            this.CBdob2.FormattingEnabled = true;
            this.CBdob2.Location = new System.Drawing.Point(243, 20);
            this.CBdob2.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob2.Name = "CBdob2";
            this.CBdob2.Size = new System.Drawing.Size(195, 24);
            this.CBdob2.TabIndex = 21;
            // 
            // CBdob5
            // 
            this.CBdob5.FormattingEnabled = true;
            this.CBdob5.Location = new System.Drawing.Point(39, 52);
            this.CBdob5.Margin = new System.Windows.Forms.Padding(4);
            this.CBdob5.Name = "CBdob5";
            this.CBdob5.Size = new System.Drawing.Size(195, 24);
            this.CBdob5.TabIndex = 20;
            // 
            // CBdob1
            // 
            this.CBdob1.AllowDrop = true;
            this.CBdob1.Location = new System.Drawing.Point(39, 20);
            this.CBdob1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBdob1.Name = "CBdob1";
            this.CBdob1.Size = new System.Drawing.Size(195, 24);
            this.CBdob1.Sorted = true;
            this.CBdob1.TabIndex = 19;
            // 
            // Bdob
            // 
            this.Bdob.Location = new System.Drawing.Point(852, 80);
            this.Bdob.Margin = new System.Windows.Forms.Padding(4);
            this.Bdob.Name = "Bdob";
            this.Bdob.Size = new System.Drawing.Size(204, 31);
            this.Bdob.TabIndex = 4;
            this.Bdob.Text = "Добавить";
            this.Bdob.UseVisualStyleBackColor = true;
            this.Bdob.Click += new System.EventHandler(this.Bdob_Click);
            // 
            // Otch
            // 
            this.Otch.Controls.Add(this.label3);
            this.Otch.Controls.Add(this.label2);
            this.Otch.Controls.Add(this.BOtch);
            this.Otch.Controls.Add(this.Totch);
            this.Otch.Location = new System.Drawing.Point(4, 25);
            this.Otch.Name = "Otch";
            this.Otch.Padding = new System.Windows.Forms.Padding(3);
            this.Otch.Size = new System.Drawing.Size(1067, 131);
            this.Otch.TabIndex = 3;
            this.Otch.Text = "Отчет";
            this.Otch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчет поместит в excel данные о проводимых в группе занятиях";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Номер группы";
            // 
            // BOtch
            // 
            this.BOtch.Location = new System.Drawing.Point(496, 73);
            this.BOtch.Name = "BOtch";
            this.BOtch.Size = new System.Drawing.Size(138, 32);
            this.BOtch.TabIndex = 1;
            this.BOtch.Text = "Создать отчет";
            this.BOtch.UseVisualStyleBackColor = true;
            this.BOtch.Click += new System.EventHandler(this.BOtch_Click);
            // 
            // Totch
            // 
            this.Totch.Location = new System.Drawing.Point(371, 73);
            this.Totch.Name = "Totch";
            this.Totch.Size = new System.Drawing.Size(100, 22);
            this.Totch.TabIndex = 0;
            // 
            // ToUsers
            // 
            this.ToUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToUsers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ToUsers.FormattingEnabled = true;
            this.ToUsers.Location = new System.Drawing.Point(1250, 440);
            this.ToUsers.Margin = new System.Windows.Forms.Padding(4);
            this.ToUsers.Name = "ToUsers";
            this.ToUsers.Size = new System.Drawing.Size(95, 24);
            this.ToUsers.TabIndex = 9;
            this.ToUsers.SelectedValueChanged += new System.EventHandler(this.ToUser);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 543);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1807, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem,
            this.импортToolStripMenuItem,
            this.создатьОтчетToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.menuClose);
            // 
            // импортToolStripMenuItem
            // 
            this.импортToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокАудиторийToolStripMenuItem,
            this.списокГруппToolStripMenuItem});
            this.импортToolStripMenuItem.Name = "импортToolStripMenuItem";
            this.импортToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.импортToolStripMenuItem.Text = "Импорт";
            // 
            // списокАудиторийToolStripMenuItem
            // 
            this.списокАудиторийToolStripMenuItem.Name = "списокАудиторийToolStripMenuItem";
            this.списокАудиторийToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.списокАудиторийToolStripMenuItem.Text = "Список аудиторий";
            this.списокАудиторийToolStripMenuItem.Click += new System.EventHandler(this.ImpListAud);
            // 
            // списокГруппToolStripMenuItem
            // 
            this.списокГруппToolStripMenuItem.Name = "списокГруппToolStripMenuItem";
            this.списокГруппToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.списокГруппToolStripMenuItem.Text = "Список групп";
            this.списокГруппToolStripMenuItem.Click += new System.EventHandler(this.ImpListGroups);
            // 
            // создатьОтчетToolStripMenuItem
            // 
            this.создатьОтчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчет1ToolStripMenuItem});
            this.создатьОтчетToolStripMenuItem.Name = "создатьОтчетToolStripMenuItem";
            this.создатьОтчетToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.создатьОтчетToolStripMenuItem.Text = "Экспорт";
            // 
            // отчет1ToolStripMenuItem
            // 
            this.отчет1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыГруппToolStripMenuItem,
            this.таблицыАудиторийToolStripMenuItem,
            this.расписанияToolStripMenuItem,
            this.базыДанныхToolStripMenuItem});
            this.отчет1ToolStripMenuItem.Name = "отчет1ToolStripMenuItem";
            this.отчет1ToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.отчет1ToolStripMenuItem.Text = "Создать резервную копию";
            // 
            // таблицыГруппToolStripMenuItem
            // 
            this.таблицыГруппToolStripMenuItem.Name = "таблицыГруппToolStripMenuItem";
            this.таблицыГруппToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.таблицыГруппToolStripMenuItem.Text = "Таблицы групп";
            this.таблицыГруппToolStripMenuItem.Click += new System.EventHandler(this.ExpGroups);
            // 
            // таблицыАудиторийToolStripMenuItem
            // 
            this.таблицыАудиторийToolStripMenuItem.Name = "таблицыАудиторийToolStripMenuItem";
            this.таблицыАудиторийToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.таблицыАудиторийToolStripMenuItem.Text = "Таблицы аудиторий";
            this.таблицыАудиторийToolStripMenuItem.Click += new System.EventHandler(this.ExpAuds);
            // 
            // расписанияToolStripMenuItem
            // 
            this.расписанияToolStripMenuItem.Name = "расписанияToolStripMenuItem";
            this.расписанияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.расписанияToolStripMenuItem.Text = "Расписания";
            this.расписанияToolStripMenuItem.Click += new System.EventHandler(this.ExpRasp);
            // 
            // базыДанныхToolStripMenuItem
            // 
            this.базыДанныхToolStripMenuItem.Name = "базыДанныхToolStripMenuItem";
            this.базыДанныхToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.базыДанныхToolStripMenuItem.Text = "Базы данных";
            this.базыДанныхToolStripMenuItem.Click += new System.EventHandler(this.Expall);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.Spravka);
            // 
            // DMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 575);
            this.Controls.Add(this.box);
            this.Controls.Add(this.ToUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(3000, 750);
            this.MinimumSize = new System.Drawing.Size(1215, 479);
            this.Name = "DMS";
            this.Text = "Редактирование базы данных";
            this.ClientSizeChanged += new System.EventHandler(this.Dinamica);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.box.ResumeLayout(false);
            this.Pdel.ResumeLayout(false);
            this.Pd.ResumeLayout(false);
            this.Otch.ResumeLayout(false);
            this.Otch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TabControl box;
        private System.Windows.Forms.TabPage Pdel;
        private System.Windows.Forms.ComboBox CBdel;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.TabPage Pd;
        private System.Windows.Forms.Button Bupd;
        private System.Windows.Forms.ComboBox CBdob12;
        private System.Windows.Forms.ComboBox CBdob11;
        private System.Windows.Forms.ComboBox CBdob10;
        private System.Windows.Forms.ComboBox CBdob9;
        private System.Windows.Forms.ComboBox CBdob8;
        private System.Windows.Forms.ComboBox CBdob4;
        private System.Windows.Forms.ComboBox CBdob7;
        private System.Windows.Forms.ComboBox CBdob3;
        private System.Windows.Forms.ComboBox CBdob6;
        private System.Windows.Forms.ComboBox CBdob2;
        private System.Windows.Forms.ComboBox CBdob5;
        protected System.Windows.Forms.ComboBox CBdob1;
        private System.Windows.Forms.Button Bdob;
        private System.Windows.Forms.ComboBox ToUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчет1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокАудиторийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокГруппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыГруппToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицыАудиторийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расписанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem базыДанныхToolStripMenuItem;
        private System.Windows.Forms.TabPage Otch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BOtch;
        private System.Windows.Forms.TextBox Totch;
        private System.Windows.Forms.Label label3;
    }
}


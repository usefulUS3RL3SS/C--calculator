
namespace rgz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            button14 = new Button();
            CalculateButton = new Button();
            button25 = new Button();
            button24 = new Button();
            button23 = new Button();
            button22 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button13 = new Button();
            button15 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            menuStrip1 = new MenuStrip();
            EditToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem = new ToolStripMenuItem();
            EnterToolStripMenuItem = new ToolStripMenuItem();
            SettingToolStripMenuItem = new ToolStripMenuItem();
            FracToolStripMenuItem = new ToolStripMenuItem();
            NumToolStripMenuItem = new ToolStripMenuItem();
            AboutToolStripMenuItem1 = new ToolStripMenuItem();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button14
            // 
            button14.CausesValidation = false;
            button14.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button14.Location = new Point(139, 234);
            button14.Margin = new Padding(4);
            button14.Name = "button14";
            button14.Size = new Size(53, 49);
            button14.TabIndex = 45;
            button14.TabStop = false;
            button14.Tag = "5";
            button14.Text = "5";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Button_Number_Edit;
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            CalculateButton.ForeColor = Color.SlateBlue;
            CalculateButton.Location = new Point(323, 291);
            CalculateButton.Margin = new Padding(4);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(53, 103);
            CalculateButton.TabIndex = 57;
            CalculateButton.Tag = "";
            CalculateButton.Text = "=";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += Button_Calculate;
            // 
            // button25
            // 
            button25.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button25.ForeColor = SystemColors.ControlText;
            button25.Location = new Point(323, 234);
            button25.Margin = new Padding(4);
            button25.Name = "button25";
            button25.Size = new Size(53, 49);
            button25.TabIndex = 56;
            button25.Tag = "0";
            button25.Text = "1/x";
            button25.UseVisualStyleBackColor = true;
            button25.Click += Button_Number_Function;
            // 
            // button24
            // 
            button24.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button24.ForeColor = Color.SlateBlue;
            button24.Location = new Point(261, 345);
            button24.Margin = new Padding(4);
            button24.Name = "button24";
            button24.Size = new Size(53, 49);
            button24.TabIndex = 55;
            button24.Tag = "1";
            button24.Text = "+";
            button24.UseVisualStyleBackColor = true;
            button24.Click += Button_Number_Operation;
            // 
            // button23
            // 
            button23.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button23.ForeColor = Color.SlateBlue;
            button23.Location = new Point(261, 290);
            button23.Margin = new Padding(4);
            button23.Name = "button23";
            button23.Size = new Size(53, 49);
            button23.TabIndex = 54;
            button23.Tag = "2";
            button23.Text = "-";
            button23.UseVisualStyleBackColor = true;
            button23.Click += Button_Number_Operation;
            // 
            // button22
            // 
            button22.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button22.ForeColor = Color.SlateBlue;
            button22.Location = new Point(261, 234);
            button22.Margin = new Padding(4);
            button22.Name = "button22";
            button22.Size = new Size(53, 49);
            button22.TabIndex = 53;
            button22.Tag = "3";
            button22.Text = "*";
            button22.UseVisualStyleBackColor = true;
            button22.Click += Button_Number_Operation;
            // 
            // button19
            // 
            button19.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button19.ForeColor = SystemColors.ControlDarkDark;
            button19.Location = new Point(200, 345);
            button19.Margin = new Padding(4);
            button19.Name = "button19";
            button19.Size = new Size(53, 49);
            button19.TabIndex = 52;
            button19.Tag = "11";
            button19.Text = "\\";
            button19.UseVisualStyleBackColor = true;
            button19.Click += Button_Number_Edit;
            // 
            // button20
            // 
            button20.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button20.ForeColor = SystemColors.ControlDarkDark;
            button20.Location = new Point(77, 345);
            button20.Margin = new Padding(4);
            button20.Name = "button20";
            button20.Size = new Size(53, 49);
            button20.TabIndex = 51;
            button20.Tag = "10";
            button20.Text = "+/-";
            button20.UseVisualStyleBackColor = true;
            button20.Click += Button_Number_Edit;
            // 
            // button21
            // 
            button21.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button21.Location = new Point(139, 345);
            button21.Margin = new Padding(4);
            button21.Name = "button21";
            button21.Size = new Size(53, 49);
            button21.TabIndex = 50;
            button21.Tag = "0";
            button21.Text = "0";
            button21.UseVisualStyleBackColor = true;
            button21.Click += Button_Number_Edit;
            // 
            // button16
            // 
            button16.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button16.Location = new Point(200, 291);
            button16.Margin = new Padding(4);
            button16.Name = "button16";
            button16.Size = new Size(53, 49);
            button16.TabIndex = 49;
            button16.TabStop = false;
            button16.Tag = "9";
            button16.Text = "9";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Button_Number_Edit;
            // 
            // button17
            // 
            button17.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button17.Location = new Point(139, 291);
            button17.Margin = new Padding(4);
            button17.Name = "button17";
            button17.Size = new Size(53, 49);
            button17.TabIndex = 48;
            button17.Tag = "8";
            button17.Text = "8";
            button17.UseVisualStyleBackColor = true;
            button17.Click += Button_Number_Edit;
            // 
            // button18
            // 
            button18.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button18.Location = new Point(77, 291);
            button18.Margin = new Padding(4);
            button18.Name = "button18";
            button18.Size = new Size(53, 49);
            button18.TabIndex = 47;
            button18.Tag = "7";
            button18.Text = "7";
            button18.UseVisualStyleBackColor = true;
            button18.Click += Button_Number_Edit;
            // 
            // button13
            // 
            button13.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button13.Location = new Point(200, 234);
            button13.Margin = new Padding(4);
            button13.Name = "button13";
            button13.Size = new Size(53, 49);
            button13.TabIndex = 46;
            button13.Tag = "6";
            button13.Text = "6";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Button_Number_Edit;
            // 
            // button15
            // 
            button15.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button15.Location = new Point(77, 234);
            button15.Margin = new Padding(4);
            button15.Name = "button15";
            button15.Size = new Size(53, 49);
            button15.TabIndex = 44;
            button15.Tag = "4";
            button15.Text = "4";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Button_Number_Edit;
            // 
            // button12
            // 
            button12.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button12.ForeColor = Color.SlateBlue;
            button12.Location = new Point(16, 345);
            button12.Margin = new Padding(4);
            button12.Name = "button12";
            button12.RightToLeft = RightToLeft.No;
            button12.Size = new Size(53, 49);
            button12.TabIndex = 43;
            button12.Tag = "1";
            button12.Text = "M+";
            button12.UseVisualStyleBackColor = true;
            button12.Click += Button_Memory;
            // 
            // button11
            // 
            button11.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.SlateBlue;
            button11.Location = new Point(16, 290);
            button11.Margin = new Padding(4);
            button11.Name = "button11";
            button11.RightToLeft = RightToLeft.No;
            button11.Size = new Size(53, 49);
            button11.TabIndex = 42;
            button11.Tag = "0";
            button11.Text = "MS";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Button_Memory;
            // 
            // button10
            // 
            button10.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button10.ForeColor = Color.SlateBlue;
            button10.Location = new Point(16, 234);
            button10.Margin = new Padding(4);
            button10.Name = "button10";
            button10.RightToLeft = RightToLeft.No;
            button10.Size = new Size(53, 49);
            button10.TabIndex = 41;
            button10.Tag = "3";
            button10.Text = "MR";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Button_Memory;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ControlText;
            button9.Location = new Point(323, 176);
            button9.Margin = new Padding(4);
            button9.Name = "button9";
            button9.Size = new Size(53, 49);
            button9.TabIndex = 40;
            button9.Tag = "1";
            button9.Text = "Sqr";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_Number_Function;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.SlateBlue;
            button8.Location = new Point(261, 176);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(53, 49);
            button8.TabIndex = 39;
            button8.Tag = "4";
            button8.Text = "/";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_Number_Operation;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { EditToolStripMenuItem, SettingToolStripMenuItem, AboutToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(392, 28);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // EditToolStripMenuItem
            // 
            EditToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CopyToolStripMenuItem, EnterToolStripMenuItem });
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            EditToolStripMenuItem.Size = new Size(74, 24);
            EditToolStripMenuItem.Text = "&Правка";
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.Size = new Size(176, 26);
            CopyToolStripMenuItem.Text = "&Копировать";
            CopyToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // EnterToolStripMenuItem
            // 
            EnterToolStripMenuItem.Name = "EnterToolStripMenuItem";
            EnterToolStripMenuItem.Size = new Size(176, 26);
            EnterToolStripMenuItem.Text = "&Вставить";
            EnterToolStripMenuItem.Click += EnterToolStripMenuItem_Click;
            // 
            // SettingToolStripMenuItem
            // 
            SettingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FracToolStripMenuItem, NumToolStripMenuItem });
            SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            SettingToolStripMenuItem.Size = new Size(97, 24);
            SettingToolStripMenuItem.Text = "&Настройка";
            // 
            // FracToolStripMenuItem
            // 
            FracToolStripMenuItem.Checked = true;
            FracToolStripMenuItem.CheckState = CheckState.Checked;
            FracToolStripMenuItem.Name = "FracToolStripMenuItem";
            FracToolStripMenuItem.Size = new Size(455, 26);
            FracToolStripMenuItem.Text = "Дробь (отображение всегда в виде дроби)";
            FracToolStripMenuItem.Click += FracToolStripMenuItem_Click;
            // 
            // NumToolStripMenuItem
            // 
            NumToolStripMenuItem.Name = "NumToolStripMenuItem";
            NumToolStripMenuItem.Size = new Size(455, 26);
            NumToolStripMenuItem.Text = "Число (при возможности отображать в виде числа)";
            NumToolStripMenuItem.Click += NumToolStripMenuItem_Click;
            // 
            // AboutToolStripMenuItem1
            // 
            AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1";
            AboutToolStripMenuItem1.ShortcutKeyDisplayString = "";
            AboutToolStripMenuItem1.Size = new Size(81, 24);
            AboutToolStripMenuItem1.Text = "&Справка";
            AboutToolStripMenuItem1.Click += AboutToolStripMenuItem1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(200, 176);
            button7.Margin = new Padding(4);
            button7.Name = "button7";
            button7.Size = new Size(53, 49);
            button7.TabIndex = 38;
            button7.Tag = "3";
            button7.Text = "3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_Number_Edit;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(139, 176);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(53, 49);
            button6.TabIndex = 37;
            button6.Tag = "2";
            button6.Text = "2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_Number_Edit;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(77, 176);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(53, 49);
            button5.TabIndex = 36;
            button5.Tag = "1";
            button5.Text = "1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_Number_Edit;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.SlateBlue;
            button4.Location = new Point(16, 176);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(53, 49);
            button4.TabIndex = 35;
            button4.Tag = "2";
            button4.Text = "MC";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Memory;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.SlateBlue;
            button3.Location = new Point(323, 117);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(53, 49);
            button3.TabIndex = 34;
            button3.Tag = "Reset";
            button3.Text = "C";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Reset;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.SlateBlue;
            button2.Location = new Point(200, 117);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(114, 49);
            button2.TabIndex = 33;
            button2.Tag = "13";
            button2.Text = "CE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Number_Edit;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.SlateBlue;
            button1.Location = new Point(77, 117);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(115, 49);
            button1.TabIndex = 32;
            button1.Tag = "12";
            button1.Text = "<-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Number_Edit;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Microsoft Tai Le", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(16, 117);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 49);
            label1.TabIndex = 31;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(16, 55);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(359, 34);
            textBox1.TabIndex = 30;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(392, 404);
            Controls.Add(CalculateButton);
            Controls.Add(button25);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button21);
            Controls.Add(button16);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(menuStrip1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(410, 451);
            MinimizeBox = false;
            MinimumSize = new Size(410, 451);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор простых дробей";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private Button button25;
        private Button button24;
        private Button button23;
        private Button button22;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button13;
        private Button button15;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem CopyToolStripMenuItem;
        private ToolStripMenuItem EnterToolStripMenuItem;
        private ToolStripMenuItem SettingToolStripMenuItem;
        private ToolStripMenuItem FracToolStripMenuItem;
        private ToolStripMenuItem NumToolStripMenuItem;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private ToolStripMenuItem AboutToolStripMenuItem1;
        private Button button14;
    }
}


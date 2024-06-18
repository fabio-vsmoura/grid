namespace grid
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
            components = new System.ComponentModel.Container();
            tb_nome = new TextBox();
            tb_email = new TextBox();
            tb_senha = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grid = new DataGridView();
            timer = new System.Windows.Forms.Timer(components);
            lb_timer = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(508, 83);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(241, 23);
            tb_nome.TabIndex = 0;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(508, 138);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(241, 23);
            tb_email.TabIndex = 1;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(508, 195);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(123, 23);
            tb_senha.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(674, 195);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(674, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Exibir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(593, 415);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Recarregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(508, 65);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(508, 120);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 7;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(508, 177);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // grid
            // 
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(12, 65);
            grid.Name = "grid";
            grid.Size = new Size(462, 352);
            grid.TabIndex = 9;
            grid.CellClick += grid_CellClick;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // lb_timer
            // 
            lb_timer.AutoSize = true;
            lb_timer.Location = new Point(12, 423);
            lb_timer.Name = "lb_timer";
            lb_timer.Size = new Size(0, 15);
            lb_timer.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(512, 415);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Cadastrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(lb_timer);
            Controls.Add(grid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tb_senha);
            Controls.Add(tb_email);
            Controls.Add(tb_nome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nome;
        private TextBox tb_email;
        private TextBox tb_senha;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView grid;
        private System.Windows.Forms.Timer timer;
        private Label lb_timer;
        private Button button4;
    }
}

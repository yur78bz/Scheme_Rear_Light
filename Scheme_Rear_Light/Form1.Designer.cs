namespace Scheme_Rear_Light
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb15PIN = new System.Windows.Forms.ComboBox();
            this.socket15BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shemeDataSet = new Scheme_Rear_Light.ShemeDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.socket_15TableAdapter = new Scheme_Rear_Light.ShemeDataSetTableAdapters.Socket_15TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.socket15Socket7NBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socket_7NTableAdapter = new Scheme_Rear_Light.ShemeDataSetTableAdapters.Socket_7NTableAdapter();
            this.socket15Socket7SBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socket_7STableAdapter = new Scheme_Rear_Light.ShemeDataSetTableAdapters.Socket_7STableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.socket15SocketRearLightRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.socket15SocketRearLightLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.socket_RearLight_LTableAdapter = new Scheme_Rear_Light.ShemeDataSetTableAdapters.Socket_RearLight_LTableAdapter();
            this.socket_RearLight_RTableAdapter = new Scheme_Rear_Light.ShemeDataSetTableAdapters.Socket_RearLight_RTableAdapter();
            this.lb8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shemeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15Socket7NBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15Socket7SBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15SocketRearLightRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15SocketRearLightLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1186, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmb15PIN
            // 
            this.cmb15PIN.DataSource = this.socket15BindingSource;
            this.cmb15PIN.DisplayMember = "Item";
            this.cmb15PIN.FormattingEnabled = true;
            this.cmb15PIN.Location = new System.Drawing.Point(16, 74);
            this.cmb15PIN.Margin = new System.Windows.Forms.Padding(4);
            this.cmb15PIN.Name = "cmb15PIN";
            this.cmb15PIN.Size = new System.Drawing.Size(340, 24);
            this.cmb15PIN.TabIndex = 2;
            this.cmb15PIN.ValueMember = "Idc";
            this.cmb15PIN.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // socket15BindingSource
            // 
            this.socket15BindingSource.DataMember = "Socket_15";
            this.socket15BindingSource.DataSource = this.shemeDataSet;
            // 
            // shemeDataSet
            // 
            this.shemeDataSet.DataSetName = "ShemeDataSet";
            this.shemeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Контакт  розетки 15PIN";
            // 
            // socket_15TableAdapter
            // 
            this.socket_15TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15BindingSource, "Idc", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(362, 74);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 22);
            this.textBox1.TabIndex = 4;
            // 
            // socket15Socket7NBindingSource
            // 
            this.socket15Socket7NBindingSource.DataMember = "Socket_15Socket_7N";
            this.socket15Socket7NBindingSource.DataSource = this.socket15BindingSource;
            // 
            // socket_7NTableAdapter
            // 
            this.socket_7NTableAdapter.ClearBeforeFill = true;
            // 
            // socket15Socket7SBindingSource
            // 
            this.socket15Socket7SBindingSource.DataMember = "Socket_15Socket_7S";
            this.socket15Socket7SBindingSource.DataSource = this.socket15BindingSource;
            // 
            // socket_7STableAdapter
            // 
            this.socket_7STableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15Socket7NBindingSource, "Item", true));
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(16, 27);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(340, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Контакт  розетки 7N";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Контакт  розетки 7S";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15Socket7SBindingSource, "Item", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(16, 121);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(340, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15Socket7NBindingSource, "Id", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(362, 27);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 22);
            this.textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15Socket7SBindingSource, "Id", true));
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(362, 121);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(42, 22);
            this.textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15SocketRearLightRBindingSource, "Id", true));
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(793, 27);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(42, 22);
            this.textBox6.TabIndex = 11;
            // 
            // socket15SocketRearLightRBindingSource
            // 
            this.socket15SocketRearLightRBindingSource.DataMember = "Socket_15Socket_RearLight_R";
            this.socket15SocketRearLightRBindingSource.DataSource = this.socket15BindingSource;
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15SocketRearLightRBindingSource, "Item", true));
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(839, 27);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(340, 22);
            this.textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15SocketRearLightLBindingSource, "Item", true));
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(839, 121);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(340, 22);
            this.textBox8.TabIndex = 14;
            // 
            // socket15SocketRearLightLBindingSource
            // 
            this.socket15SocketRearLightLBindingSource.DataMember = "Socket_15Socket_RearLight_L";
            this.socket15SocketRearLightLBindingSource.DataSource = this.socket15BindingSource;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socket15SocketRearLightLBindingSource, "Id", true));
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(793, 121);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(42, 22);
            this.textBox9.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "№конт.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(787, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "№конт.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(839, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Фара задняя правая";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(839, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Фара задняя левая";
            // 
            // socket_RearLight_LTableAdapter
            // 
            this.socket_RearLight_LTableAdapter.ClearBeforeFill = true;
            // 
            // socket_RearLight_RTableAdapter
            // 
            this.socket_RearLight_RTableAdapter.ClearBeforeFill = true;
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(566, 65);
            this.lb8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(39, 16);
            this.lb8.TabIndex = 19;
            this.lb8.Text = "Цвет";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 160);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb15PIN);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СХЕМА ПОДКЛЮЧЕНИЯ ЗАДНИХ ФАР";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shemeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15Socket7NBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15Socket7SBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15SocketRearLightRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socket15SocketRearLightLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb15PIN;
        private System.Windows.Forms.Label label1;
        private ShemeDataSet shemeDataSet;
        private System.Windows.Forms.BindingSource socket15BindingSource;
        private ShemeDataSetTableAdapters.Socket_15TableAdapter socket_15TableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource socket15Socket7NBindingSource;
        private ShemeDataSetTableAdapters.Socket_7NTableAdapter socket_7NTableAdapter;
        private System.Windows.Forms.BindingSource socket15Socket7SBindingSource;
        private ShemeDataSetTableAdapters.Socket_7STableAdapter socket_7STableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource socket15SocketRearLightLBindingSource;
        private ShemeDataSetTableAdapters.Socket_RearLight_LTableAdapter socket_RearLight_LTableAdapter;
        private System.Windows.Forms.BindingSource socket15SocketRearLightRBindingSource;
        private ShemeDataSetTableAdapters.Socket_RearLight_RTableAdapter socket_RearLight_RTableAdapter;
        private System.Windows.Forms.Label lb8;
    }
}


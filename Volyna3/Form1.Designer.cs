namespace Volyna3
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
            comboBoxType = new ComboBox();
            textBoxPrice = new TextBox();
            textBoxSpeed = new TextBox();
            textBoxYear = new TextBox();
            textBoxHeight = new TextBox();
            textBoxPassengers = new TextBox();
            textBoxPort = new TextBox();
            buttonCreate = new Button();
            listBoxOutput = new ListBox();
            Vehicle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            btnCloneSelected = new Button();
            btnSortVehicles = new Button();
            btnSortVehiclesQueue = new Button();
            btnCloneSelectedQueue = new Button();
            Queue = new Label();
            SuspendLayout();
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(12, 28);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(151, 28);
            comboBoxType.TabIndex = 0;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(12, 123);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(125, 27);
            textBoxPrice.TabIndex = 1;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(165, 123);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(125, 27);
            textBoxSpeed.TabIndex = 2;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(308, 123);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(125, 27);
            textBoxYear.TabIndex = 3;
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(12, 186);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(125, 27);
            textBoxHeight.TabIndex = 4;
            // 
            // textBoxPassengers
            // 
            textBoxPassengers.Location = new Point(165, 186);
            textBoxPassengers.Name = "textBoxPassengers";
            textBoxPassengers.Size = new Size(125, 27);
            textBoxPassengers.TabIndex = 5;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(308, 186);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(125, 27);
            textBoxPort.TabIndex = 6;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(12, 247);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 7;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.Location = new Point(448, 13);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(534, 384);
            listBoxOutput.TabIndex = 9;
            listBoxOutput.Click += listBoxOutput_Click;
            // 
            // Vehicle
            // 
            Vehicle.AutoSize = true;
            Vehicle.Location = new Point(12, 5);
            Vehicle.Name = "Vehicle";
            Vehicle.Size = new Size(56, 20);
            Vehicle.TabIndex = 10;
            Vehicle.Text = "Vehicle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 11;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 100);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 12;
            label3.Text = "Speed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 100);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 13;
            label4.Text = "Year";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 163);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 14;
            label5.Text = "Height";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 163);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 15;
            label6.Text = "Passengers";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(308, 163);
            label7.Name = "label7";
            label7.Size = new Size(35, 20);
            label7.TabIndex = 16;
            label7.Text = "Port";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(988, 15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(534, 384);
            listBox1.TabIndex = 17;
            // 
            // btnCloneSelected
            // 
            btnCloneSelected.Location = new Point(12, 282);
            btnCloneSelected.Name = "btnCloneSelected";
            btnCloneSelected.Size = new Size(94, 29);
            btnCloneSelected.TabIndex = 18;
            btnCloneSelected.Text = "Clone";
            btnCloneSelected.UseVisualStyleBackColor = true;
            btnCloneSelected.Click += btnCloneSelected_Click;
            // 
            // btnSortVehicles
            // 
            btnSortVehicles.Location = new Point(12, 317);
            btnSortVehicles.Name = "btnSortVehicles";
            btnSortVehicles.Size = new Size(94, 29);
            btnSortVehicles.TabIndex = 19;
            btnSortVehicles.Text = "Sort";
            btnSortVehicles.UseVisualStyleBackColor = true;
            btnSortVehicles.Click += btnSortVehicles_Click;
            // 
            // btnSortVehiclesQueue
            // 
            btnSortVehiclesQueue.Location = new Point(308, 317);
            btnSortVehiclesQueue.Name = "btnSortVehiclesQueue";
            btnSortVehiclesQueue.Size = new Size(94, 29);
            btnSortVehiclesQueue.TabIndex = 21;
            btnSortVehiclesQueue.Text = "Sort";
            btnSortVehiclesQueue.UseVisualStyleBackColor = true;
            btnSortVehiclesQueue.Click += btnSortVehiclesQueue_Click;
            // 
            // btnCloneSelectedQueue
            // 
            btnCloneSelectedQueue.Location = new Point(308, 282);
            btnCloneSelectedQueue.Name = "btnCloneSelectedQueue";
            btnCloneSelectedQueue.Size = new Size(94, 29);
            btnCloneSelectedQueue.TabIndex = 20;
            btnCloneSelectedQueue.Text = "Clone";
            btnCloneSelectedQueue.UseVisualStyleBackColor = true;
            btnCloneSelectedQueue.Click += btnCloneSelectedQueue_Click;
            // 
            // Queue
            // 
            Queue.AutoSize = true;
            Queue.Font = new Font("Algerian", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Queue.Location = new Point(308, 251);
            Queue.Name = "Queue";
            Queue.Size = new Size(95, 25);
            Queue.TabIndex = 22;
            Queue.Text = "Queue:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1545, 411);
            Controls.Add(Queue);
            Controls.Add(btnSortVehiclesQueue);
            Controls.Add(btnCloneSelectedQueue);
            Controls.Add(btnSortVehicles);
            Controls.Add(btnCloneSelected);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Vehicle);
            Controls.Add(listBoxOutput);
            Controls.Add(buttonCreate);
            Controls.Add(textBoxPort);
            Controls.Add(textBoxPassengers);
            Controls.Add(textBoxHeight);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxSpeed);
            Controls.Add(textBoxPrice);
            Controls.Add(comboBoxType);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxType;
        private TextBox textBoxPrice;
        private TextBox textBoxSpeed;
        private TextBox textBoxYear;
        private TextBox textBoxHeight;
        private TextBox textBoxPassengers;
        private TextBox textBoxPort;
        private Button buttonCreate;
        private ListBox listBoxOutput;
        private Label Vehicle;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private Button btnCloneSelected;
        private Button btnSortVehicles;
        private Button btnSortVehiclesQueue;
        private Button btnCloneSelectedQueue;
        private Label Queue;
    }
}

namespace ProjectDevelopmentInN_TierArchitectureWithOOP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxId = new System.Windows.Forms.TextBox();
            this.BtList = new System.Windows.Forms.Button();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TbxJop = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbtF = new System.Windows.Forms.RadioButton();
            this.RbtT = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployeeList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEmployeeList
            // 
            this.DgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmployeeList.Location = new System.Drawing.Point(12, 181);
            this.DgvEmployeeList.Name = "DgvEmployeeList";
            this.DgvEmployeeList.Size = new System.Drawing.Size(776, 266);
            this.DgvEmployeeList.TabIndex = 0;
            this.DgvEmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmployeeList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id:";
            // 
            // TbxId
            // 
            this.TbxId.Enabled = false;
            this.TbxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxId.Location = new System.Drawing.Point(103, 32);
            this.TbxId.Name = "TbxId";
            this.TbxId.ReadOnly = true;
            this.TbxId.Size = new System.Drawing.Size(100, 26);
            this.TbxId.TabIndex = 2;
            // 
            // BtList
            // 
            this.BtList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtList.Location = new System.Drawing.Point(17, 23);
            this.BtList.Name = "BtList";
            this.BtList.Size = new System.Drawing.Size(135, 46);
            this.BtList.TabIndex = 3;
            this.BtList.Text = "LIST";
            this.BtList.UseVisualStyleBackColor = true;
            this.BtList.Click += new System.EventHandler(this.BtList_Click);
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxName.Location = new System.Drawing.Point(103, 64);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(100, 26);
            this.TbxName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // TbxSurname
            // 
            this.TbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxSurname.Location = new System.Drawing.Point(103, 96);
            this.TbxSurname.Name = "TbxSurname";
            this.TbxSurname.Size = new System.Drawing.Size(100, 26);
            this.TbxSurname.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Surname:";
            // 
            // TbxCity
            // 
            this.TbxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxCity.Location = new System.Drawing.Point(103, 128);
            this.TbxCity.Name = "TbxCity";
            this.TbxCity.Size = new System.Drawing.Size(100, 26);
            this.TbxCity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(225, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Salary:";
            // 
            // TbxSalary
            // 
            this.TbxSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxSalary.Location = new System.Drawing.Point(293, 32);
            this.TbxSalary.Name = "TbxSalary";
            this.TbxSalary.Size = new System.Drawing.Size(100, 26);
            this.TbxSalary.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(53, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(230, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "State:";
            // 
            // TbxJop
            // 
            this.TbxJop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbxJop.Location = new System.Drawing.Point(293, 96);
            this.TbxJop.Name = "TbxJop";
            this.TbxJop.Size = new System.Drawing.Size(100, 26);
            this.TbxJop.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(243, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Job:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbtF);
            this.groupBox1.Controls.Add(this.RbtT);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 163);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // RbtF
            // 
            this.RbtF.AutoSize = true;
            this.RbtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbtF.Location = new System.Drawing.Point(345, 52);
            this.RbtF.Name = "RbtF";
            this.RbtF.Size = new System.Drawing.Size(37, 24);
            this.RbtF.TabIndex = 1;
            this.RbtF.TabStop = true;
            this.RbtF.Text = "F";
            this.RbtF.UseVisualStyleBackColor = true;
            // 
            // RbtT
            // 
            this.RbtT.AutoSize = true;
            this.RbtT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbtT.Location = new System.Drawing.Point(281, 52);
            this.RbtT.Name = "RbtT";
            this.RbtT.Size = new System.Drawing.Size(36, 24);
            this.RbtT.TabIndex = 0;
            this.RbtT.TabStop = true;
            this.RbtT.Text = "T";
            this.RbtT.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtUpdate);
            this.groupBox2.Controls.Add(this.BtAdd);
            this.groupBox2.Controls.Add(this.BtDelete);
            this.groupBox2.Controls.Add(this.BtList);
            this.groupBox2.Location = new System.Drawing.Point(434, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 163);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations";
            // 
            // BtUpdate
            // 
            this.BtUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUpdate.Location = new System.Drawing.Point(190, 99);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(135, 46);
            this.BtUpdate.TabIndex = 6;
            this.BtUpdate.Text = "UPDATE";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtAdd.Location = new System.Drawing.Point(17, 99);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(135, 46);
            this.BtAdd.TabIndex = 5;
            this.BtAdd.Text = "INSERT";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // BtDelete
            // 
            this.BtDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtDelete.Location = new System.Drawing.Point(190, 23);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(135, 46);
            this.BtDelete.TabIndex = 4;
            this.BtDelete.Text = "DELETE";
            this.BtDelete.UseVisualStyleBackColor = true;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbxJop);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbxSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvEmployeeList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "N-Tier Architecture With OOP";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployeeList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEmployeeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxId;
        private System.Windows.Forms.Button BtList;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbxJop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.RadioButton RbtF;
        private System.Windows.Forms.RadioButton RbtT;
    }
}


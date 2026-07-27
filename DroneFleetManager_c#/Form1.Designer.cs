namespace DroneFleetManager_c_
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAddDeliivery = new Button();
            btnAddSurveillance = new Button();
            panelMap = new Panel();
            dvgStation = new DataGridView();
            dgvSurveillanceDrones = new DataGridView();
            dvgDeliveryDrones = new DataGridView();
            btnDelete = new Button();
            btnMoveSelected = new Button();
            btnAssignMission = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnChargeDrone = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnstation = new Button();
            btnAutoAssign = new Button();
            missionTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dvgStation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSurveillanceDrones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgDeliveryDrones).BeginInit();
            SuspendLayout();
            // 
            // btnAddDeliivery
            // 
            btnAddDeliivery.BackColor = Color.DarkOliveGreen;
            btnAddDeliivery.FlatStyle = FlatStyle.Flat;
            btnAddDeliivery.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddDeliivery.ForeColor = Color.Transparent;
            btnAddDeliivery.Location = new Point(729, 469);
            btnAddDeliivery.Name = "btnAddDeliivery";
            btnAddDeliivery.Size = new Size(220, 34);
            btnAddDeliivery.TabIndex = 2;
            btnAddDeliivery.Text = "Add Delivery Drone";
            btnAddDeliivery.UseVisualStyleBackColor = false;
            btnAddDeliivery.Click += btnAddDeliivery_Click;
            // 
            // btnAddSurveillance
            // 
            btnAddSurveillance.BackColor = Color.DarkOliveGreen;
            btnAddSurveillance.FlatStyle = FlatStyle.Flat;
            btnAddSurveillance.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddSurveillance.ForeColor = Color.White;
            btnAddSurveillance.Location = new Point(1207, 656);
            btnAddSurveillance.Name = "btnAddSurveillance";
            btnAddSurveillance.Size = new Size(253, 34);
            btnAddSurveillance.TabIndex = 3;
            btnAddSurveillance.Text = "Add Surveillance Drone";
            btnAddSurveillance.UseVisualStyleBackColor = false;
            btnAddSurveillance.Click += btnAddSurveillance_Click;
            // 
            // panelMap
            // 
            panelMap.BackColor = Color.Transparent;
            panelMap.Location = new Point(385, 71);
            panelMap.Name = "panelMap";
            panelMap.Size = new Size(1541, 715);
            panelMap.TabIndex = 5;
            panelMap.Paint += panelMap_Paint;
            // 
            // dvgStation
            // 
            dvgStation.AllowUserToAddRows = false;
            dvgStation.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dvgStation.BackgroundColor = Color.WhiteSmoke;
            dvgStation.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Aharoni", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dvgStation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dvgStation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dvgStation.DefaultCellStyle = dataGridViewCellStyle2;
            dvgStation.EnableHeadersVisualStyles = false;
            dvgStation.Location = new Point(1300, 575);
            dvgStation.Name = "dvgStation";
            dvgStation.RowHeadersVisible = false;
            dvgStation.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Aharoni", 8F, FontStyle.Bold, GraphicsUnit.Point, 177);
            dvgStation.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dvgStation.Size = new Size(402, 152);
            dvgStation.TabIndex = 0;
            dvgStation.CellContentClick += dvgStation_CellContentClick;
            // 
            // dgvSurveillanceDrones
            // 
            dgvSurveillanceDrones.AllowUserToAddRows = false;
            dgvSurveillanceDrones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgvSurveillanceDrones.BackgroundColor = Color.WhiteSmoke;
            dgvSurveillanceDrones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Aharoni", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSurveillanceDrones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSurveillanceDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvSurveillanceDrones.DefaultCellStyle = dataGridViewCellStyle5;
            dgvSurveillanceDrones.EnableHeadersVisualStyles = false;
            dgvSurveillanceDrones.GridColor = Color.DarkOliveGreen;
            dgvSurveillanceDrones.Location = new Point(680, 575);
            dgvSurveillanceDrones.Name = "dgvSurveillanceDrones";
            dgvSurveillanceDrones.RowHeadersVisible = false;
            dgvSurveillanceDrones.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Aharoni", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvSurveillanceDrones.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvSurveillanceDrones.Size = new Size(589, 152);
            dgvSurveillanceDrones.TabIndex = 1;
            dgvSurveillanceDrones.CellContentClick += dgvSurveillanceDrones_CellContentClick;
            // 
            // dvgDeliveryDrones
            // 
            dvgDeliveryDrones.AllowUserToAddRows = false;
            dvgDeliveryDrones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dvgDeliveryDrones.BackgroundColor = Color.WhiteSmoke;
            dvgDeliveryDrones.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new Font("Aharoni", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dvgDeliveryDrones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dvgDeliveryDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.DarkOliveGreen;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dvgDeliveryDrones.DefaultCellStyle = dataGridViewCellStyle8;
            dvgDeliveryDrones.EnableHeadersVisualStyles = false;
            dvgDeliveryDrones.GridColor = Color.DarkOliveGreen;
            dvgDeliveryDrones.Location = new Point(27, 579);
            dvgDeliveryDrones.Name = "dvgDeliveryDrones";
            dvgDeliveryDrones.RowHeadersVisible = false;
            dvgDeliveryDrones.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new Font("Aharoni", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dvgDeliveryDrones.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dvgDeliveryDrones.Size = new Size(631, 152);
            dvgDeliveryDrones.TabIndex = 2;
            dvgDeliveryDrones.CellContentClick += dvgDeliveryDrones_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkOliveGreen;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(39, 427);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(340, 54);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMoveSelected
            // 
            btnMoveSelected.BackColor = Color.DarkOliveGreen;
            btnMoveSelected.FlatStyle = FlatStyle.Flat;
            btnMoveSelected.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMoveSelected.ForeColor = Color.Transparent;
            btnMoveSelected.Location = new Point(39, 487);
            btnMoveSelected.Name = "btnMoveSelected";
            btnMoveSelected.Size = new Size(340, 51);
            btnMoveSelected.TabIndex = 7;
            btnMoveSelected.Text = "Move Selected";
            btnMoveSelected.UseVisualStyleBackColor = false;
            btnMoveSelected.Click += btnMoveSelected_Click;
            // 
            // btnAssignMission
            // 
            btnAssignMission.BackColor = Color.DarkOliveGreen;
            btnAssignMission.FlatStyle = FlatStyle.Flat;
            btnAssignMission.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAssignMission.ForeColor = Color.Transparent;
            btnAssignMission.Location = new Point(39, 240);
            btnAssignMission.Name = "btnAssignMission";
            btnAssignMission.Size = new Size(340, 54);
            btnAssignMission.TabIndex = 8;
            btnAssignMission.Text = "Assign Mission";
            btnAssignMission.UseVisualStyleBackColor = false;
            btnAssignMission.Click += btnAssignMission_Click_1;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkOliveGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Transparent;
            btnSave.Location = new Point(39, 544);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(340, 54);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.DarkOliveGreen;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoad.ForeColor = Color.Transparent;
            btnLoad.Location = new Point(39, 604);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(340, 55);
            btnLoad.TabIndex = 10;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnChargeDrone
            // 
            btnChargeDrone.BackColor = Color.DarkOliveGreen;
            btnChargeDrone.FlatStyle = FlatStyle.Flat;
            btnChargeDrone.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChargeDrone.ForeColor = Color.Transparent;
            btnChargeDrone.Location = new Point(39, 359);
            btnChargeDrone.Name = "btnChargeDrone";
            btnChargeDrone.Size = new Size(340, 62);
            btnChargeDrone.TabIndex = 11;
            btnChargeDrone.Text = "Charge Selected Drone";
            btnChargeDrone.UseVisualStyleBackColor = false;
            btnChargeDrone.Click += btnChargeDrone_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(27, 522);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 12;
            label1.Text = "Delivery Drones";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.WhiteSmoke;
            label2.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(686, 522);
            label2.Name = "label2";
            label2.Size = new Size(354, 38);
            label2.TabIndex = 13;
            label2.Text = "Surveillance Drone";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(1312, 522);
            label3.Name = "label3";
            label3.Size = new Size(314, 38);
            label3.TabIndex = 14;
            label3.Text = "Charging Station";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.WhiteSmoke;
            label4.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOliveGreen;
            label4.Location = new Point(39, 182);
            label4.Name = "label4";
            label4.Size = new Size(164, 43);
            label4.TabIndex = 15;
            label4.Text = "Actions";
            // 
            // btnstation
            // 
            btnstation.BackColor = Color.DarkOliveGreen;
            btnstation.FlatStyle = FlatStyle.Flat;
            btnstation.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnstation.ForeColor = Color.White;
            btnstation.Location = new Point(1530, 497);
            btnstation.Name = "btnstation";
            btnstation.Size = new Size(162, 34);
            btnstation.TabIndex = 16;
            btnstation.Text = "Add Station";
            btnstation.UseVisualStyleBackColor = false;
            btnstation.Click += btnstation_Click;
            // 
            // btnAutoAssign
            // 
            btnAutoAssign.BackColor = Color.DarkOliveGreen;
            btnAutoAssign.FlatStyle = FlatStyle.Flat;
            btnAutoAssign.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAutoAssign.ForeColor = Color.Transparent;
            btnAutoAssign.Location = new Point(39, 300);
            btnAutoAssign.Name = "btnAutoAssign";
            btnAutoAssign.Size = new Size(340, 53);
            btnAutoAssign.TabIndex = 17;
            btnAutoAssign.Text = "Auto Assign Mission";
            btnAutoAssign.UseVisualStyleBackColor = false;
            btnAutoAssign.Click += btnAutoAssign_Click;
            // 
            // missionTimer
            // 
            missionTimer.Interval = 3000;
            missionTimer.Tick += missionTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1714, 823);
            Controls.Add(btnAutoAssign);
            Controls.Add(btnAddSurveillance);
            Controls.Add(btnstation);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChargeDrone);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnAddDeliivery);
            Controls.Add(dgvSurveillanceDrones);
            Controls.Add(dvgDeliveryDrones);
            Controls.Add(btnAssignMission);
            Controls.Add(dvgStation);
            Controls.Add(btnDelete);
            Controls.Add(btnMoveSelected);
            Controls.Add(panelMap);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dvgStation).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSurveillanceDrones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgDeliveryDrones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddDeliivery;
        private Button btnAddSurveillance;
        private Panel panelMap;
        private Button btnDelete;
        private Button btnMoveSelected;
        private Button btnAssignMission;
        private DataGridView dvgDeliveryDrones;
        private DataGridView dgvSurveillanceDrones;
        private DataGridView dvgStation;
        private Button btnSave;
        private Button btnLoad;
        private Button btnChargeDrone;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnstation;
        private Button btnAutoAssign;
        private System.Windows.Forms.Timer missionTimer;
    }
}

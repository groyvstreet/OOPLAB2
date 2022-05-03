namespace Lab2
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.FiguresPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioEllipse = new System.Windows.Forms.RadioButton();
            this.radioPolyline = new System.Windows.Forms.RadioButton();
            this.radioPolygon = new System.Windows.Forms.RadioButton();
            this.ParamsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonPenColor = new System.Windows.Forms.Button();
            this.buttonBrushColor = new System.Windows.Forms.Button();
            this.trackPenWidth = new System.Windows.Forms.TrackBar();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.brushColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.FiguresPanel.SuspendLayout();
            this.ParamsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(982, 453);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // FiguresPanel
            // 
            this.FiguresPanel.Controls.Add(this.radioLine);
            this.FiguresPanel.Controls.Add(this.radioRectangle);
            this.FiguresPanel.Controls.Add(this.radioEllipse);
            this.FiguresPanel.Controls.Add(this.radioPolyline);
            this.FiguresPanel.Controls.Add(this.radioPolygon);
            this.FiguresPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.FiguresPanel.Location = new System.Drawing.Point(836, 0);
            this.FiguresPanel.Name = "FiguresPanel";
            this.FiguresPanel.Size = new System.Drawing.Size(146, 453);
            this.FiguresPanel.TabIndex = 1;
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioLine.Location = new System.Drawing.Point(3, 3);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(75, 24);
            this.radioLine.TabIndex = 0;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "Линия";
            this.radioLine.UseVisualStyleBackColor = true;
            this.radioLine.CheckedChanged += new System.EventHandler(this.radioLine_CheckedChanged);
            // 
            // radioRectangle
            // 
            this.radioRectangle.AutoSize = true;
            this.radioRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioRectangle.Location = new System.Drawing.Point(3, 33);
            this.radioRectangle.Name = "radioRectangle";
            this.radioRectangle.Size = new System.Drawing.Size(141, 24);
            this.radioRectangle.TabIndex = 1;
            this.radioRectangle.TabStop = true;
            this.radioRectangle.Text = "Прямоугольник";
            this.radioRectangle.UseVisualStyleBackColor = true;
            this.radioRectangle.CheckedChanged += new System.EventHandler(this.radioRectangle_CheckedChanged);
            // 
            // radioEllipse
            // 
            this.radioEllipse.AutoSize = true;
            this.radioEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioEllipse.Location = new System.Drawing.Point(3, 63);
            this.radioEllipse.Name = "radioEllipse";
            this.radioEllipse.Size = new System.Drawing.Size(80, 24);
            this.radioEllipse.TabIndex = 2;
            this.radioEllipse.TabStop = true;
            this.radioEllipse.Text = "Эллипс";
            this.radioEllipse.UseVisualStyleBackColor = true;
            this.radioEllipse.CheckedChanged += new System.EventHandler(this.radioEllipse_CheckedChanged);
            // 
            // radioPolyline
            // 
            this.radioPolyline.AutoSize = true;
            this.radioPolyline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPolyline.Location = new System.Drawing.Point(3, 93);
            this.radioPolyline.Name = "radioPolyline";
            this.radioPolyline.Size = new System.Drawing.Size(93, 24);
            this.radioPolyline.TabIndex = 3;
            this.radioPolyline.TabStop = true;
            this.radioPolyline.Text = "Ломаная";
            this.radioPolyline.UseVisualStyleBackColor = true;
            this.radioPolyline.CheckedChanged += new System.EventHandler(this.radioPolyline_CheckedChanged);
            // 
            // radioPolygon
            // 
            this.radioPolygon.AutoSize = true;
            this.radioPolygon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPolygon.Location = new System.Drawing.Point(3, 123);
            this.radioPolygon.Name = "radioPolygon";
            this.radioPolygon.Size = new System.Drawing.Size(139, 24);
            this.radioPolygon.TabIndex = 4;
            this.radioPolygon.TabStop = true;
            this.radioPolygon.Text = "Многоугольник";
            this.radioPolygon.UseVisualStyleBackColor = true;
            this.radioPolygon.CheckedChanged += new System.EventHandler(this.radioPolygon_CheckedChanged);
            // 
            // ParamsPanel
            // 
            this.ParamsPanel.Controls.Add(this.buttonPenColor);
            this.ParamsPanel.Controls.Add(this.buttonBrushColor);
            this.ParamsPanel.Controls.Add(this.trackPenWidth);
            this.ParamsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ParamsPanel.Location = new System.Drawing.Point(0, 0);
            this.ParamsPanel.Name = "ParamsPanel";
            this.ParamsPanel.Size = new System.Drawing.Size(117, 453);
            this.ParamsPanel.TabIndex = 2;
            // 
            // buttonPenColor
            // 
            this.buttonPenColor.BackColor = System.Drawing.Color.Black;
            this.buttonPenColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPenColor.Location = new System.Drawing.Point(3, 3);
            this.buttonPenColor.Name = "buttonPenColor";
            this.buttonPenColor.Size = new System.Drawing.Size(29, 29);
            this.buttonPenColor.TabIndex = 0;
            this.buttonPenColor.UseVisualStyleBackColor = false;
            this.buttonPenColor.Click += new System.EventHandler(this.buttonBrushColor_Click);
            // 
            // buttonBrushColor
            // 
            this.buttonBrushColor.BackColor = System.Drawing.Color.White;
            this.buttonBrushColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrushColor.Location = new System.Drawing.Point(38, 3);
            this.buttonBrushColor.Name = "buttonBrushColor";
            this.buttonBrushColor.Size = new System.Drawing.Size(29, 29);
            this.buttonBrushColor.TabIndex = 1;
            this.buttonBrushColor.UseVisualStyleBackColor = false;
            this.buttonBrushColor.Click += new System.EventHandler(this.buttonFillColor_Click);
            // 
            // trackPenWidth
            // 
            this.trackPenWidth.Location = new System.Drawing.Point(3, 38);
            this.trackPenWidth.Minimum = 1;
            this.trackPenWidth.Name = "trackPenWidth";
            this.trackPenWidth.Size = new System.Drawing.Size(114, 56);
            this.trackPenWidth.TabIndex = 2;
            this.trackPenWidth.Value = 1;
            this.trackPenWidth.Scroll += new System.EventHandler(this.trackPenWidth_Scroll);
            // 
            // brushColorDialog
            // 
            this.brushColorDialog.Color = System.Drawing.Color.White;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.ParamsPanel);
            this.Controls.Add(this.FiguresPanel);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.FiguresPanel.ResumeLayout(false);
            this.FiguresPanel.PerformLayout();
            this.ParamsPanel.ResumeLayout(false);
            this.ParamsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox;
        private FlowLayoutPanel FiguresPanel;
        private RadioButton radioLine;
        private RadioButton radioRectangle;
        private RadioButton radioEllipse;
        private RadioButton radioPolyline;
        private RadioButton radioPolygon;
        private FlowLayoutPanel ParamsPanel;
        private ColorDialog penColorDialog;
        private Button buttonPenColor;
        private Button buttonBrushColor;
        private ColorDialog brushColorDialog;
        private TrackBar trackPenWidth;
    }
}
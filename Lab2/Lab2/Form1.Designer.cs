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
            this.figuresPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.radioSelect = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.radioRectangle = new System.Windows.Forms.RadioButton();
            this.radioEllipse = new System.Windows.Forms.RadioButton();
            this.radioPolyline = new System.Windows.Forms.RadioButton();
            this.radioPolygon = new System.Windows.Forms.RadioButton();
            this.toolsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRedo = new System.Windows.Forms.Button();
            this.buttonUndoAll = new System.Windows.Forms.Button();
            this.buttonRedoAll = new System.Windows.Forms.Button();
            this.buttonCopyFigure = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonPenColor = new System.Windows.Forms.Button();
            this.buttonBrushColor = new System.Windows.Forms.Button();
            this.checkBoxBrush = new System.Windows.Forms.CheckBox();
            this.trackPenWidth = new System.Windows.Forms.TrackBar();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.brushColorDialog = new System.Windows.Forms.ColorDialog();
            this.paramsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.figuresPanel.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).BeginInit();
            this.paramsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 35);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(982, 418);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // figuresPanel
            // 
            this.figuresPanel.Controls.Add(this.radioSelect);
            this.figuresPanel.Controls.Add(this.radioLine);
            this.figuresPanel.Controls.Add(this.radioRectangle);
            this.figuresPanel.Controls.Add(this.radioEllipse);
            this.figuresPanel.Controls.Add(this.radioPolyline);
            this.figuresPanel.Controls.Add(this.radioPolygon);
            this.figuresPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.figuresPanel.Location = new System.Drawing.Point(836, 35);
            this.figuresPanel.Name = "figuresPanel";
            this.figuresPanel.Size = new System.Drawing.Size(146, 418);
            this.figuresPanel.TabIndex = 1;
            // 
            // radioSelect
            // 
            this.radioSelect.AutoSize = true;
            this.radioSelect.Location = new System.Drawing.Point(3, 3);
            this.radioSelect.Name = "radioSelect";
            this.radioSelect.Size = new System.Drawing.Size(90, 24);
            this.radioSelect.TabIndex = 5;
            this.radioSelect.TabStop = true;
            this.radioSelect.Text = "Выбрать";
            this.radioSelect.UseVisualStyleBackColor = true;
            this.radioSelect.CheckedChanged += new System.EventHandler(this.radioSelect_CheckedChanged);
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioLine.Location = new System.Drawing.Point(3, 33);
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
            this.radioRectangle.Location = new System.Drawing.Point(3, 63);
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
            this.radioEllipse.Location = new System.Drawing.Point(3, 93);
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
            this.radioPolyline.Location = new System.Drawing.Point(3, 123);
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
            this.radioPolygon.Location = new System.Drawing.Point(3, 153);
            this.radioPolygon.Name = "radioPolygon";
            this.radioPolygon.Size = new System.Drawing.Size(139, 24);
            this.radioPolygon.TabIndex = 4;
            this.radioPolygon.TabStop = true;
            this.radioPolygon.Text = "Многоугольник";
            this.radioPolygon.UseVisualStyleBackColor = true;
            this.radioPolygon.CheckedChanged += new System.EventHandler(this.radioPolygon_CheckedChanged);
            // 
            // toolsPanel
            // 
            this.toolsPanel.Controls.Add(this.buttonUndo);
            this.toolsPanel.Controls.Add(this.buttonRedo);
            this.toolsPanel.Controls.Add(this.buttonUndoAll);
            this.toolsPanel.Controls.Add(this.buttonRedoAll);
            this.toolsPanel.Controls.Add(this.buttonCopyFigure);
            this.toolsPanel.Controls.Add(this.buttonSave);
            this.toolsPanel.Controls.Add(this.buttonOpen);
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.Location = new System.Drawing.Point(0, 35);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Size = new System.Drawing.Size(100, 418);
            this.toolsPanel.TabIndex = 2;
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(3, 3);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(94, 29);
            this.buttonUndo.TabIndex = 0;
            this.buttonUndo.Text = "Отменить";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRedo
            // 
            this.buttonRedo.Location = new System.Drawing.Point(3, 38);
            this.buttonRedo.Name = "buttonRedo";
            this.buttonRedo.Size = new System.Drawing.Size(94, 29);
            this.buttonRedo.TabIndex = 1;
            this.buttonRedo.Text = "Повторить";
            this.buttonRedo.UseVisualStyleBackColor = true;
            this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
            // 
            // buttonUndoAll
            // 
            this.buttonUndoAll.Location = new System.Drawing.Point(3, 73);
            this.buttonUndoAll.Name = "buttonUndoAll";
            this.buttonUndoAll.Size = new System.Drawing.Size(94, 58);
            this.buttonUndoAll.TabIndex = 2;
            this.buttonUndoAll.Text = "Отменить всё";
            this.buttonUndoAll.UseVisualStyleBackColor = true;
            this.buttonUndoAll.Click += new System.EventHandler(this.buttonUndoAll_Click);
            // 
            // buttonRedoAll
            // 
            this.buttonRedoAll.Location = new System.Drawing.Point(3, 137);
            this.buttonRedoAll.Name = "buttonRedoAll";
            this.buttonRedoAll.Size = new System.Drawing.Size(94, 58);
            this.buttonRedoAll.TabIndex = 3;
            this.buttonRedoAll.Text = "Повторить всё";
            this.buttonRedoAll.UseVisualStyleBackColor = true;
            this.buttonRedoAll.Click += new System.EventHandler(this.buttonRedoAll_Click);
            // 
            // buttonCopyFigure
            // 
            this.buttonCopyFigure.Enabled = false;
            this.buttonCopyFigure.Location = new System.Drawing.Point(3, 201);
            this.buttonCopyFigure.Name = "buttonCopyFigure";
            this.buttonCopyFigure.Size = new System.Drawing.Size(94, 29);
            this.buttonCopyFigure.TabIndex = 4;
            this.buttonCopyFigure.Text = "Клон";
            this.buttonCopyFigure.UseVisualStyleBackColor = true;
            this.buttonCopyFigure.Click += new System.EventHandler(this.buttonCopyFigure_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(3, 236);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 29);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(3, 271);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(94, 29);
            this.buttonOpen.TabIndex = 6;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
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
            // checkBoxBrush
            // 
            this.checkBoxBrush.AutoSize = true;
            this.checkBoxBrush.Location = new System.Drawing.Point(73, 3);
            this.checkBoxBrush.Name = "checkBoxBrush";
            this.checkBoxBrush.Size = new System.Drawing.Size(87, 24);
            this.checkBoxBrush.TabIndex = 3;
            this.checkBoxBrush.Text = "Заливка";
            this.checkBoxBrush.UseVisualStyleBackColor = true;
            this.checkBoxBrush.CheckedChanged += new System.EventHandler(this.checkBoxBrush_CheckedChanged);
            // 
            // trackPenWidth
            // 
            this.trackPenWidth.Location = new System.Drawing.Point(166, 3);
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
            // paramsPanel
            // 
            this.paramsPanel.Controls.Add(this.buttonPenColor);
            this.paramsPanel.Controls.Add(this.buttonBrushColor);
            this.paramsPanel.Controls.Add(this.checkBoxBrush);
            this.paramsPanel.Controls.Add(this.trackPenWidth);
            this.paramsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.paramsPanel.Location = new System.Drawing.Point(0, 0);
            this.paramsPanel.Name = "paramsPanel";
            this.paramsPanel.Size = new System.Drawing.Size(982, 35);
            this.paramsPanel.TabIndex = 4;
            // 
            // saveDialog
            // 
            this.saveDialog.DefaultExt = "json";
            this.saveDialog.Tag = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.toolsPanel);
            this.Controls.Add(this.figuresPanel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.paramsPanel);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.figuresPanel.ResumeLayout(false);
            this.figuresPanel.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackPenWidth)).EndInit();
            this.paramsPanel.ResumeLayout(false);
            this.paramsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox;
        private FlowLayoutPanel figuresPanel;
        private RadioButton radioLine;
        private RadioButton radioRectangle;
        private RadioButton radioEllipse;
        private RadioButton radioPolyline;
        private RadioButton radioPolygon;
        private FlowLayoutPanel toolsPanel;
        private ColorDialog penColorDialog;
        private Button buttonPenColor;
        private Button buttonBrushColor;
        private ColorDialog brushColorDialog;
        private TrackBar trackPenWidth;
        private CheckBox checkBoxBrush;
        private FlowLayoutPanel paramsPanel;
        private Button buttonUndo;
        private Button buttonRedo;
        private Button buttonUndoAll;
        private Button buttonRedoAll;
        private RadioButton radioSelect;
        private Button buttonCopyFigure;
        private Button buttonSave;
        private Button buttonOpen;
        private SaveFileDialog saveDialog;
        private OpenFileDialog openDialog;
    }
}
namespace win_form;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.CheckBox checkBoxItalic;
    
    private System.Windows.Forms.ComboBox comboBoxTextWidth;
    private System.Windows.Forms.ComboBox comboBoxTextHeight;
    private System.Windows.Forms.ListBox listBoxLog;
    private System.Windows.Forms.ComboBox comboBoxImageScale;
    private System.Windows.Forms.ComboBox comboBoxTextFont;
    private System.Windows.Forms.CheckBox checkBoxUnderline;
    private System.Windows.Forms.ComboBox comboBoxTextJustification;


    
    private System.Windows.Forms.GroupBox groupBoxStatus;
    private System.Windows.Forms.Label labelStatus;
    private System.Windows.Forms.TextBox textBoxTextToPrint;
    
    private System.Windows.Forms.CheckBox checkBoxBold;
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
        labelStatus = new Label();
        groupBoxStatus = new GroupBox();
        listBoxLog = new ListBox();
        comboBoxImageScale = new ComboBox();
        textBoxTextToPrint = new TextBox();
        checkBoxBold = new CheckBox();
        checkBoxItalic = new CheckBox();
        checkBoxUnderline = new CheckBox();
        comboBoxTextFont = new ComboBox();
        comboBoxTextWidth = new ComboBox();
        comboBoxTextJustification = new ComboBox();
        btnOpenPrinter = new Button();
        SuspendLayout();
        // 
        // labelStatus
        // 
        labelStatus.Font = new Font("Courier New", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelStatus.Location = new Point(2, 264);
        labelStatus.Margin = new Padding(4, 0, 4, 0);
        labelStatus.Name = "labelStatus";
        labelStatus.Size = new Size(797, 177);
        labelStatus.TabIndex = 0;
        // 
        // groupBoxStatus
        // 
        groupBoxStatus.Enabled = false;
        groupBoxStatus.Location = new Point(17, 351);
        groupBoxStatus.Margin = new Padding(4);
        groupBoxStatus.Name = "groupBoxStatus";
        groupBoxStatus.Padding = new Padding(4);
        groupBoxStatus.Size = new Size(847, 191);
        groupBoxStatus.TabIndex = 11;
        groupBoxStatus.TabStop = false;
        groupBoxStatus.Text = "Status";
        // 
        // listBoxLog
        // 
        listBoxLog.FormattingEnabled = true;
        listBoxLog.Location = new Point(11, 25);
        listBoxLog.Margin = new Padding(4);
        listBoxLog.Name = "listBoxLog";
        listBoxLog.Size = new Size(827, 148);
        listBoxLog.TabIndex = 0;
        // 
        // comboBoxImageScale
        // 
        comboBoxImageScale.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxImageScale.FormattingEnabled = true;
        comboBoxImageScale.Items.AddRange(new object[] { "SCALE NONE", "SCALE to FIT", "SCALE to WIDTH (300)" });
        comboBoxImageScale.Location = new Point(427, 27);
        comboBoxImageScale.Margin = new Padding(4);
        comboBoxImageScale.Name = "comboBoxImageScale";
        comboBoxImageScale.Size = new Size(244, 23);
        comboBoxImageScale.TabIndex = 29;
        // 
        // textBoxTextToPrint
        // 
        textBoxTextToPrint.Location = new Point(427, 62);
        textBoxTextToPrint.Margin = new Padding(4);
        textBoxTextToPrint.Name = "textBoxTextToPrint";
        textBoxTextToPrint.Size = new Size(244, 23);
        textBoxTextToPrint.TabIndex = 10;
        // 
        // checkBoxBold
        // 
        checkBoxBold.AutoSize = true;
        checkBoxBold.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        checkBoxBold.Location = new Point(680, 60);
        checkBoxBold.Margin = new Padding(4);
        checkBoxBold.Name = "checkBoxBold";
        checkBoxBold.Size = new Size(40, 21);
        checkBoxBold.TabIndex = 11;
        checkBoxBold.Text = "B";
        checkBoxBold.UseVisualStyleBackColor = true;
        // 
        // checkBoxItalic
        // 
        checkBoxItalic.AutoSize = true;
        checkBoxItalic.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
        checkBoxItalic.Location = new Point(732, 60);
        checkBoxItalic.Margin = new Padding(4);
        checkBoxItalic.Name = "checkBoxItalic";
        checkBoxItalic.Size = new Size(33, 21);
        checkBoxItalic.TabIndex = 12;
        checkBoxItalic.Text = "I";
        checkBoxItalic.UseVisualStyleBackColor = true;
        // 
        // checkBoxUnderline
        // 
        checkBoxUnderline.AutoSize = true;
        checkBoxUnderline.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
        checkBoxUnderline.Location = new Point(779, 60);
        checkBoxUnderline.Margin = new Padding(4);
        checkBoxUnderline.Name = "checkBoxUnderline";
        checkBoxUnderline.Size = new Size(40, 21);
        checkBoxUnderline.TabIndex = 13;
        checkBoxUnderline.Text = "U";
        checkBoxUnderline.UseVisualStyleBackColor = true;
        // 
        // comboBoxTextFont
        // 
        comboBoxTextFont.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTextFont.FormattingEnabled = true;
        comboBoxTextFont.Items.AddRange(new object[] { "Font 1", "Font 2", "Font 3", "Font 4" });
        comboBoxTextFont.Location = new Point(735, 96);
        comboBoxTextFont.Margin = new Padding(4);
        comboBoxTextFont.Name = "comboBoxTextFont";
        comboBoxTextFont.Size = new Size(93, 23);
        comboBoxTextFont.TabIndex = 17;
        // 
        // comboBoxTextWidth
        // 
        comboBoxTextWidth.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTextWidth.FormattingEnabled = true;
        comboBoxTextWidth.Items.AddRange(new object[] { "Width X1", "Width X2", "Width X3", "Width X4", "Width X5", "Width X6", "Width X7", "Width X8" });
        comboBoxTextWidth.Location = new Point(427, 96);
        comboBoxTextWidth.Margin = new Padding(4);
        comboBoxTextWidth.Name = "comboBoxTextWidth";
        comboBoxTextWidth.Size = new Size(93, 23);
        comboBoxTextWidth.TabIndex = 14;
        // 
        // comboBoxTextJustification
        // 
        comboBoxTextJustification.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBoxTextJustification.FormattingEnabled = true;
        comboBoxTextJustification.Items.AddRange(new object[] { "Left", "Center", "Right" });
        comboBoxTextJustification.Location = new Point(632, 96);
        comboBoxTextJustification.Margin = new Padding(4);
        comboBoxTextJustification.Name = "comboBoxTextJustification";
        comboBoxTextJustification.Size = new Size(93, 23);
        comboBoxTextJustification.TabIndex = 16;
        // 
        // btnOpenPrinter
        // 
        btnOpenPrinter.Location = new Point(2, 226);
        btnOpenPrinter.Name = "btnOpenPrinter";
        btnOpenPrinter.Size = new Size(143, 23);
        btnOpenPrinter.TabIndex = 12;
        btnOpenPrinter.Text = "Abre status";
        btnOpenPrinter.UseVisualStyleBackColor = true;
        btnOpenPrinter.Click += btnOpenPrinter_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnOpenPrinter);
        Controls.Add(labelStatus);
        Controls.Add(groupBoxStatus);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private Button btnOpenPrinter;
}
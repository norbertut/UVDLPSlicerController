﻿namespace UV_DLP_3D_Printer.GUI.Controls
{
    partial class ctl3DView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainViewSplitContainer = new System.Windows.Forms.SplitContainer();
            this.ctlScene1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlScene();
            this.ctlMeshTools1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlMeshTools();
            this.buttMeshTools = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttRedo = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttUndo = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.objectInfoPanel = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlObjectInfo();
            this.numLayer = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlNumber();
            this.buttGlHome = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttView = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlViewOptions = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlView();
            this.buttScale = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.buttMove = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlSupport = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlSupports();
            this.buttSupports = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlObjRotate = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlRotate();
            this.buttRotate = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlImageButton();
            this.ctlObjScale = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlScale();
            this.ctlObjMove = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlMove();
            this.glControl1 = new UV_DLP_3D_Printer.GUI.Controls.ctlGL();
            this.ctlToolTip1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlToolTip();
            this.mainViewSplitContainer.Panel2.SuspendLayout();
            this.mainViewSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainViewSplitContainer
            // 
            this.mainViewSplitContainer.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainViewSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainViewSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainViewSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainViewSplitContainer.Name = "mainViewSplitContainer";
            // 
            // mainViewSplitContainer.Panel2
            // 
            this.mainViewSplitContainer.Panel2.Controls.Add(this.ctlScene1);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.ctlMeshTools1);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttMeshTools);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttRedo);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttUndo);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.objectInfoPanel);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.numLayer);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttGlHome);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttView);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.ctlViewOptions);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttScale);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttMove);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.ctlSupport);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttSupports);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.ctlObjRotate);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.buttRotate);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.ctlObjScale);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.ctlObjMove);
            this.mainViewSplitContainer.Panel2.Controls.Add(this.glControl1);
            this.mainViewSplitContainer.Panel2.SizeChanged += new System.EventHandler(this.mainViewSplitContainer_Panel2_SizeChanged);
            this.mainViewSplitContainer.Size = new System.Drawing.Size(1006, 550);
            this.mainViewSplitContainer.SplitterDistance = 144;
            this.mainViewSplitContainer.TabIndex = 28;
            // 
            // ctlScene1
            // 
            this.ctlScene1.Checked = false;
            this.ctlScene1.Gapx = 24;
            this.ctlScene1.Gapy = 100;
            this.ctlScene1.GuiAnchor = null;
            this.ctlScene1.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.ctlScene1.Location = new System.Drawing.Point(507, 47);
            this.ctlScene1.Name = "ctlScene1";
            this.ctlScene1.Size = new System.Drawing.Size(310, 297);
            this.ctlScene1.TabIndex = 33;
            this.ctlScene1.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            this.ctlScene1.Visible = false;
            // 
            // ctlMeshTools1
            // 
            this.ctlMeshTools1.BackColor = System.Drawing.Color.Navy;
            this.ctlMeshTools1.Location = new System.Drawing.Point(94, 282);
            this.ctlMeshTools1.Name = "ctlMeshTools1";
            this.ctlMeshTools1.Size = new System.Drawing.Size(343, 214);
            this.ctlMeshTools1.TabIndex = 32;
            this.ctlMeshTools1.Visible = false;
            // 
            // buttMeshTools
            // 
            this.buttMeshTools.BackColor = System.Drawing.Color.Navy;
            this.buttMeshTools.Checked = false;
            this.buttMeshTools.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttOpenClose;
            this.buttMeshTools.Gapx = 10;
            this.buttMeshTools.Gapy = 288;
            this.buttMeshTools.GuiAnchor = null;
            this.buttMeshTools.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttMeshTools.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttMeshTools;
            this.buttMeshTools.Location = new System.Drawing.Point(10, 214);
            this.buttMeshTools.Name = "buttMeshTools";
            this.buttMeshTools.Size = new System.Drawing.Size(48, 48);
            this.buttMeshTools.TabIndex = 31;
            this.ctlToolTip1.SetToolTip(this.buttMeshTools, "Mesh Tools");
            this.buttMeshTools.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.buttMeshTools.Click += new System.EventHandler(this.buttMeshTools_Click);
            // 
            // buttRedo
            // 
            this.buttRedo.BackColor = System.Drawing.Color.Navy;
            this.buttRedo.Checked = false;
            this.buttRedo.CheckImage = null;
            this.buttRedo.Gapx = 60;
            this.buttRedo.Gapy = 10;
            this.buttRedo.GuiAnchor = null;
            this.buttRedo.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttRedo.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttRedo;
            this.buttRedo.Location = new System.Drawing.Point(15, 133);
            this.buttRedo.Name = "buttRedo";
            this.buttRedo.Size = new System.Drawing.Size(48, 48);
            this.buttRedo.TabIndex = 30;
            this.ctlToolTip1.SetToolTip(this.buttRedo, "Undo");
            this.buttRedo.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // buttUndo
            // 
            this.buttUndo.BackColor = System.Drawing.Color.Navy;
            this.buttUndo.Checked = false;
            this.buttUndo.CheckImage = null;
            this.buttUndo.Gapx = 10;
            this.buttUndo.Gapy = 10;
            this.buttUndo.GuiAnchor = null;
            this.buttUndo.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttUndo.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttUndo;
            this.buttUndo.Location = new System.Drawing.Point(15, 79);
            this.buttUndo.Name = "buttUndo";
            this.buttUndo.Size = new System.Drawing.Size(48, 48);
            this.buttUndo.TabIndex = 29;
            this.ctlToolTip1.SetToolTip(this.buttUndo, "Undo");
            this.buttUndo.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            // 
            // objectInfoPanel
            // 
            this.objectInfoPanel.Checked = false;
            this.objectInfoPanel.Gapx = 24;
            this.objectInfoPanel.Gapy = 24;
            this.objectInfoPanel.GuiAnchor = null;
            this.objectInfoPanel.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.objectInfoPanel.Location = new System.Drawing.Point(534, 286);
            this.objectInfoPanel.Name = "objectInfoPanel";
            this.objectInfoPanel.Size = new System.Drawing.Size(300, 240);
            this.objectInfoPanel.TabIndex = 28;
            this.objectInfoPanel.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.objectInfoPanel.Visible = false;
            // 
            // numLayer
            // 
            this.numLayer.BackColor = System.Drawing.Color.RoyalBlue;
            this.numLayer.ButtonsColor = System.Drawing.Color.Navy;
            this.numLayer.Checked = false;
            this.numLayer.EnableScroll = true;
            this.numLayer.ErrorColor = System.Drawing.Color.Red;
            this.numLayer.FloatVal = 10F;
            this.numLayer.Gapx = 0;
            this.numLayer.Gapy = 80;
            this.numLayer.GuiAnchor = null;
            this.numLayer.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Center;
            this.numLayer.Increment = 1F;
            this.numLayer.IntVal = 1000;
            this.numLayer.Location = new System.Drawing.Point(103, 514);
            this.numLayer.MaxFloat = 500F;
            this.numLayer.MaxInt = 1000;
            this.numLayer.MinFloat = -500F;
            this.numLayer.MinimumSize = new System.Drawing.Size(20, 5);
            this.numLayer.MinInt = 1;
            this.numLayer.Name = "numLayer";
            this.numLayer.Size = new System.Drawing.Size(425, 24);
            this.numLayer.TabIndex = 27;
            this.numLayer.TextFont = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.numLayer.ValidColor = System.Drawing.Color.White;
            this.numLayer.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.numLayer.Visible = false;
            this.numLayer.ValueChanged += new System.EventHandler(this.numLayer_ValueChanged);
            // 
            // buttGlHome
            // 
            this.buttGlHome.BackColor = System.Drawing.Color.Navy;
            this.buttGlHome.Checked = false;
            this.buttGlHome.CheckImage = null;
            this.buttGlHome.Gapx = 10;
            this.buttGlHome.Gapy = 10;
            this.buttGlHome.GuiAnchor = null;
            this.buttGlHome.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Right;
            this.buttGlHome.Image = global::UV_DLP_3D_Printer.Properties.Resources.homeButt;
            this.buttGlHome.Location = new System.Drawing.Point(15, 15);
            this.buttGlHome.Name = "buttGlHome";
            this.buttGlHome.Size = new System.Drawing.Size(48, 48);
            this.buttGlHome.TabIndex = 16;
            this.ctlToolTip1.SetToolTip(this.buttGlHome, "Home");
            this.buttGlHome.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Top;
            this.buttGlHome.Click += new System.EventHandler(this.buttGlHome_Click);
            // 
            // buttView
            // 
            this.buttView.BackColor = System.Drawing.Color.Navy;
            this.buttView.Checked = false;
            this.buttView.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttOpenClose;
            this.buttView.Gapx = 10;
            this.buttView.Gapy = 230;
            this.buttView.GuiAnchor = null;
            this.buttView.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttView.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttView;
            this.buttView.Location = new System.Drawing.Point(10, 282);
            this.buttView.Name = "buttView";
            this.buttView.Size = new System.Drawing.Size(48, 48);
            this.buttView.TabIndex = 25;
            this.ctlToolTip1.SetToolTip(this.buttView, "View Options");
            this.buttView.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.buttView.Click += new System.EventHandler(this.buttView_Click);
            // 
            // ctlViewOptions
            // 
            this.ctlViewOptions.LayerNumberScroll = null;
            this.ctlViewOptions.Location = new System.Drawing.Point(284, 117);
            this.ctlViewOptions.MessagePanelHolder = null;
            this.ctlViewOptions.Name = "ctlViewOptions";
            this.ctlViewOptions.ObjectInfoPanel = null;
            this.ctlViewOptions.SceneControl = null;
            this.ctlViewOptions.Size = new System.Drawing.Size(170, 186);
            this.ctlViewOptions.TabIndex = 26;
            this.ctlViewOptions.TreeViewHolder = null;
            this.ctlViewOptions.Visible = false;
            // 
            // buttScale
            // 
            this.buttScale.BackColor = System.Drawing.Color.Navy;
            this.buttScale.Checked = false;
            this.buttScale.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttOpenClose;
            this.buttScale.Gapx = 10;
            this.buttScale.Gapy = 10;
            this.buttScale.GuiAnchor = null;
            this.buttScale.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttScale.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttScale;
            this.buttScale.Location = new System.Drawing.Point(10, 490);
            this.buttScale.Name = "buttScale";
            this.buttScale.Size = new System.Drawing.Size(48, 48);
            this.buttScale.TabIndex = 17;
            this.ctlToolTip1.SetToolTip(this.buttScale, "Scale object");
            this.buttScale.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.buttScale.Click += new System.EventHandler(this.buttScale_Click);
            // 
            // buttMove
            // 
            this.buttMove.BackColor = System.Drawing.Color.Navy;
            this.buttMove.Checked = false;
            this.buttMove.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttOpenClose;
            this.buttMove.Gapx = 10;
            this.buttMove.Gapy = 110;
            this.buttMove.GuiAnchor = null;
            this.buttMove.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttMove.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttMove;
            this.buttMove.Location = new System.Drawing.Point(10, 390);
            this.buttMove.Name = "buttMove";
            this.buttMove.Size = new System.Drawing.Size(48, 48);
            this.buttMove.TabIndex = 19;
            this.ctlToolTip1.SetToolTip(this.buttMove, "Move object");
            this.buttMove.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.buttMove.Click += new System.EventHandler(this.buttMove_Click);
            // 
            // ctlSupport
            // 
            this.ctlSupport.Location = new System.Drawing.Point(284, 15);
            this.ctlSupport.Name = "ctlSupport";
            this.ctlSupport.Size = new System.Drawing.Size(170, 96);
            this.ctlSupport.TabIndex = 24;
            this.ctlSupport.Visible = false;
            // 
            // buttSupports
            // 
            this.buttSupports.BackColor = System.Drawing.Color.Navy;
            this.buttSupports.Checked = false;
            this.buttSupports.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttOpenClose;
            this.buttSupports.Gapx = 10;
            this.buttSupports.Gapy = 170;
            this.buttSupports.GuiAnchor = null;
            this.buttSupports.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttSupports.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttSupport;
            this.buttSupports.Location = new System.Drawing.Point(10, 336);
            this.buttSupports.Name = "buttSupports";
            this.buttSupports.Size = new System.Drawing.Size(48, 48);
            this.buttSupports.TabIndex = 23;
            this.ctlToolTip1.SetToolTip(this.buttSupports, "Support operations");
            this.buttSupports.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.buttSupports.Click += new System.EventHandler(this.buttSupports_Click);
            // 
            // ctlObjRotate
            // 
            this.ctlObjRotate.Location = new System.Drawing.Point(665, 15);
            this.ctlObjRotate.Name = "ctlObjRotate";
            this.ctlObjRotate.Size = new System.Drawing.Size(170, 156);
            this.ctlObjRotate.TabIndex = 22;
            this.ctlObjRotate.Visible = false;
            // 
            // buttRotate
            // 
            this.buttRotate.BackColor = System.Drawing.Color.Navy;
            this.buttRotate.Checked = false;
            this.buttRotate.CheckImage = global::UV_DLP_3D_Printer.Properties.Resources.buttOpenClose;
            this.buttRotate.Gapx = 10;
            this.buttRotate.Gapy = 60;
            this.buttRotate.GuiAnchor = null;
            this.buttRotate.HorizontalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Left;
            this.buttRotate.Image = global::UV_DLP_3D_Printer.Properties.Resources.buttRotate;
            this.buttRotate.Location = new System.Drawing.Point(10, 440);
            this.buttRotate.Name = "buttRotate";
            this.buttRotate.Size = new System.Drawing.Size(48, 48);
            this.buttRotate.TabIndex = 18;
            this.ctlToolTip1.SetToolTip(this.buttRotate, "Rotate object");
            this.buttRotate.VerticalAnchor = UV_DLP_3D_Printer.GUI.CustomGUI.ctlAnchorable.AnchorTypes.Bottom;
            this.buttRotate.Click += new System.EventHandler(this.buttRotate_Click);
            // 
            // ctlObjScale
            // 
            this.ctlObjScale.Location = new System.Drawing.Point(474, 15);
            this.ctlObjScale.Name = "ctlObjScale";
            this.ctlObjScale.Size = new System.Drawing.Size(171, 199);
            this.ctlObjScale.TabIndex = 21;
            this.ctlObjScale.Visible = false;
            // 
            // ctlObjMove
            // 
            this.ctlObjMove.Location = new System.Drawing.Point(94, 15);
            this.ctlObjMove.Name = "ctlObjMove";
            this.ctlObjMove.Size = new System.Drawing.Size(170, 219);
            this.ctlObjMove.TabIndex = 20;
            this.ctlObjMove.Visible = false;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl1.Enabled = false;
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(858, 550);
            this.glControl1.TabIndex = 15;
            this.glControl1.Visible = false;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.DoubleClick += new System.EventHandler(this.glControl1_DoubleClick);
            this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyDown);
            this.glControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.glControl1_KeyPress);
            this.glControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.glControl1_KeyUp);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
            this.glControl1.MouseLeave += new System.EventHandler(this.glControl1_MouseLeave);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
            this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseUp);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // ctlToolTip1
            // 
            this.ctlToolTip1.AutoPopDelay = 5000;
            this.ctlToolTip1.BackColor = System.Drawing.Color.Turquoise;
            this.ctlToolTip1.ForeColor = System.Drawing.Color.Navy;
            this.ctlToolTip1.InitialDelay = 1500;
            this.ctlToolTip1.ReshowDelay = 100;
            // 
            // ctl3DView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mainViewSplitContainer);
            this.Name = "ctl3DView";
            this.Size = new System.Drawing.Size(1006, 550);
            this.Load += new System.EventHandler(this.ctl3DView_Load);
            this.mainViewSplitContainer.Panel2.ResumeLayout(false);
            this.mainViewSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainViewSplitContainer;
        private CustomGUI.ctlObjectInfo objectInfoPanel;
        private CustomGUI.ctlNumber numLayer;
        private CustomGUI.ctlImageButton buttGlHome;
        private CustomGUI.ctlImageButton buttView;
        private CustomGUI.ctlView ctlViewOptions;
        private CustomGUI.ctlImageButton buttScale;
        private CustomGUI.ctlImageButton buttMove;
        private CustomGUI.ctlSupports ctlSupport;
        private CustomGUI.ctlImageButton buttSupports;
        private CustomGUI.ctlRotate ctlObjRotate;
        private CustomGUI.ctlImageButton buttRotate;
        private CustomGUI.ctlScale ctlObjScale;
        private CustomGUI.ctlMove ctlObjMove;
        private CustomGUI.ctlImageButton buttUndo;
        private CustomGUI.ctlToolTip ctlToolTip1;
        private CustomGUI.ctlImageButton buttRedo;
        private CustomGUI.ctlImageButton buttMeshTools;
        private CustomGUI.ctlMeshTools ctlMeshTools1;
        private ctlGL glControl1;
        private CustomGUI.ctlScene ctlScene1;
    }
}

﻿/*
        /// <summary> 
        #region Component Designer generated code
        /// <summary> 
            this.lstGroups = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGroups
            // 
            this.lstGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lstGroups.ContextMenuStrip = this.contextMenuStrip1;
            this.lstGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstGroups.FullRowSelect = true;
            this.lstGroups.Location = new System.Drawing.Point(0, 0);
            this.lstGroups.MultiSelect = false;
            this.lstGroups.Name = "lstGroups";
            this.lstGroups.Size = new System.Drawing.Size(715, 279);
            this.lstGroups.TabIndex = 3;
            this.lstGroups.UseCompatibleStateImageBehavior = false;
            this.lstGroups.View = System.Windows.Forms.View.Details;
            this.lstGroups.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstGroups_MouseDoubleClick);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Principal Name";
            this.columnHeader15.Width = 144;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Domain";
            this.columnHeader16.Width = 141;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Description";
            this.columnHeader17.Width = 423;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToGroupToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.propertiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 98);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // addToGroupToolStripMenuItem
            // 
            this.addToGroupToolStripMenuItem.Name = "addToGroupToolStripMenuItem";
            this.addToGroupToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.addToGroupToolStripMenuItem.Text = "Add to Group...";
            this.addToGroupToolStripMenuItem.Click += new System.EventHandler(this.addToGroupToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            this.propertiesToolStripMenuItem.Click += new System.EventHandler(this.propertiesToolStripMenuItem_Click);
            // 
            // GroupsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstGroups);
            this.Name = "GroupsControl";
            this.Size = new System.Drawing.Size(715, 279);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ListView lstGroups;
    }
﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2017. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to licence terms.
// 
//  Version 4.5.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Workspace
{
	/// <summary>
	/// Storage for workspace context menu for pages.
	/// </summary>
    public class WorkspaceMenus : Storage
    {
        #region Static Fields

        private const string DEFAULT_TEXT_CLOSE = "&Close";
        private const string DEFAULT_TEXT_CLOSE_ALL_BUT_THIS = "Close &All But This";
        private const string DEFAULT_TEXT_MOVE_NEXT = "Move &Next";
        private const string DEFAULT_TEXT_MOVE_PREVIOUS = "Move &Previous";
        private const string DEFAULT_TEXT_SPLIT_VERTICAL = "Split &Vertical";
        private const string DEFAULT_TEXT_SPLIT_HORIZONTAL = "Split &Horizontal";
        private const string DEFAULT_TEXT_REBALANCE = "&Rebalance";
        private const string DEFAULT_TEXT_MAXIMIZE = "&Maximize";
        private const string DEFAULT_TEXT_RESTORE = "Res&tore";
        private const Keys DEFAULT_SHORTCUT_CLOSE = Keys.Control | Keys.Shift | Keys.C;
        private const Keys DEFAULT_SHORTCUT_CLOSE_ALL_BUT_THIS = Keys.Control | Keys.Shift | Keys.A;
        private const Keys DEFAULT_SHORTCUT_MOVE_NEXT = Keys.Control | Keys.Shift | Keys.N;
        private const Keys DEFAULT_SHORTCUT_MOVE_PREVIOUS = Keys.Control | Keys.Shift | Keys.P;
        private const Keys DEFAULT_SHORTCUT_SPLIT_VERTICAL = Keys.Control | Keys.Shift | Keys.V;
        private const Keys DEFAULT_SHORTCUT_SPLIT_HORIZONTAL = Keys.Control | Keys.Shift | Keys.H;
        private const Keys DEFAULT_SHORTCUT_REBALANCE = Keys.Control | Keys.Shift | Keys.R;
        private const Keys DEFAULT_SHORTCUT_MAXIMIZE_RESTORE = Keys.Control | Keys.Shift | Keys.M;
        #endregion

        #region Instance Fields
        private string _textClose;
        private string _textCloseAllButThis;
        private string _textMoveNext;
        private string _textMovePrevious;
        private string _textSplitVertical;
        private string _textSplitHorizontal;
        private string _textRebalance;
        private string _textMaximize;
        private string _textRestore;
        private Keys _shortcutClose;
        private Keys _shortcutCloseAllButThis;
        private Keys _shortcutMoveNext;
        private Keys _shortcutMovePrevious;
        private Keys _shortcutSplitVertical;
        private Keys _shortcutSplitHorizontal;
        private Keys _shortcutRebalance;
        private Keys _shortcutMaximizeRestore;
        private bool _showContextMenu;
        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the WorkspaceMenus class.
		/// </summary>
        public WorkspaceMenus(KryptonWorkspace workspace)
            : base()
		{
            // Default values
            _textClose = DEFAULT_TEXT_CLOSE;
            _textCloseAllButThis = DEFAULT_TEXT_CLOSE_ALL_BUT_THIS;
            _textMoveNext = DEFAULT_TEXT_MOVE_NEXT;
            _textMovePrevious = DEFAULT_TEXT_MOVE_PREVIOUS;
            _textSplitVertical = DEFAULT_TEXT_SPLIT_VERTICAL;
            _textSplitHorizontal = DEFAULT_TEXT_SPLIT_HORIZONTAL;
            _textRebalance = DEFAULT_TEXT_REBALANCE;
            _textMaximize = DEFAULT_TEXT_MAXIMIZE;
            _textRestore = DEFAULT_TEXT_RESTORE;
            _shortcutClose = DEFAULT_SHORTCUT_CLOSE;
            _shortcutCloseAllButThis = DEFAULT_SHORTCUT_CLOSE_ALL_BUT_THIS;
            _shortcutMoveNext = DEFAULT_SHORTCUT_MOVE_NEXT;
            _shortcutMovePrevious = DEFAULT_SHORTCUT_MOVE_PREVIOUS;
            _shortcutSplitVertical = DEFAULT_SHORTCUT_SPLIT_VERTICAL;
            _shortcutSplitHorizontal = DEFAULT_SHORTCUT_SPLIT_HORIZONTAL;
            _shortcutRebalance = DEFAULT_SHORTCUT_REBALANCE;
            _shortcutMaximizeRestore = DEFAULT_SHORTCUT_MAXIMIZE_RESTORE;
            _showContextMenu = true;
        }
		#endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault
        {
            get
            {
                return (TextClose.Equals(DEFAULT_TEXT_CLOSE) &&
                        TextCloseAllButThis.Equals(DEFAULT_TEXT_CLOSE_ALL_BUT_THIS) &&
                        TextMoveNext.Equals(DEFAULT_TEXT_MOVE_NEXT) &&
                        TextMovePrevious.Equals(DEFAULT_TEXT_MOVE_PREVIOUS) &&
                        TextSplitVertical.Equals(DEFAULT_TEXT_SPLIT_VERTICAL) &&
                        TextSplitHorizontal.Equals(DEFAULT_TEXT_SPLIT_HORIZONTAL) &&
                        TextRebalance.Equals(DEFAULT_TEXT_REBALANCE) &&
                        TextMaximize.Equals(DEFAULT_TEXT_MAXIMIZE) &&
                        TextRestore.Equals(DEFAULT_TEXT_RESTORE) &&
                        ShortcutClose.Equals(DEFAULT_SHORTCUT_CLOSE) &&
                        ShortcutCloseAllButThis.Equals(DEFAULT_SHORTCUT_CLOSE_ALL_BUT_THIS) &&
                        ShortcutMoveNext.Equals(DEFAULT_SHORTCUT_MOVE_NEXT) &&
                        ShortcutMovePrevious.Equals(DEFAULT_SHORTCUT_MOVE_PREVIOUS) &&
                        ShortcutSplitVertical.Equals(DEFAULT_SHORTCUT_SPLIT_VERTICAL) &&
                        ShortcutSplitHorizontal.Equals(DEFAULT_SHORTCUT_SPLIT_HORIZONTAL) &&
                        ShortcutRebalance.Equals(DEFAULT_SHORTCUT_REBALANCE) &&
                        ShortcutMaximizeRestore.Equals(DEFAULT_SHORTCUT_MAXIMIZE_RESTORE) &&
                        ShowContextMenu);
            }
        }
        #endregion

        #region TextClose
        /// <summary>
        /// Gets and sets the text to use for the close context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the close context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("&Close")]
        [Localizable(true)]
        public string TextClose
        {
            get { return _textClose; }
            set { _textClose = value; }
        }

        /// <summary>
        /// Resets the TextClose property to its default value.
        /// </summary>
        public void ResetTextClose()
        {
            TextClose = DEFAULT_TEXT_CLOSE;
        }
        #endregion

        #region TextCloseAllButThis
        /// <summary>
        /// Gets and sets the text to use for the 'close all but this' context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the 'close all but this' context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("Close &All But This")]
        [Localizable(true)]
        public string TextCloseAllButThis
        {
            get { return _textCloseAllButThis; }
            set { _textCloseAllButThis = value; }
        }

        /// <summary>
        /// Resets the TextCloseAllButThis property to its default value.
        /// </summary>
        public void ResetTextCloseAllButThis()
        {
            TextCloseAllButThis = DEFAULT_TEXT_CLOSE_ALL_BUT_THIS;
        }
        #endregion

        #region TextMoveNext
        /// <summary>
        /// Gets and sets the text to use for the move next context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the move next context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("Move &Next")]
        [Localizable(true)]
        public string TextMoveNext
        {
            get { return _textMoveNext; }
            set { _textMoveNext = value; }
        }

        /// <summary>
        /// Resets the TextMoveNext property to its default value.
        /// </summary>
        public void ResetTextMoveNext()
        {
            TextMoveNext = DEFAULT_TEXT_MOVE_NEXT;
        }
        #endregion

        #region TextMovePrevious
        /// <summary>
        /// Gets and sets the text to use for the move previous context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the move previous context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("Move &Previous")]
        [Localizable(true)]
        public string TextMovePrevious
        {
            get { return _textMovePrevious; }
            set { _textMovePrevious = value; }
        }

        /// <summary>
        /// Resets the TextMovePrevious property to its default value.
        /// </summary>
        public void ResetTextMovePrevious()
        {
            TextMovePrevious = DEFAULT_TEXT_MOVE_PREVIOUS;
        }
        #endregion

        #region TextSplitVertical
        /// <summary>
        /// Gets and sets the text to use for the split vertical context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the split vertical context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("Split &Vertical")]
        [Localizable(true)]
        public string TextSplitVertical
        {
            get { return _textSplitVertical; }
            set { _textSplitVertical = value; }
        }

        /// <summary>
        /// Resets the TextSplitVertical property to its default value.
        /// </summary>
        public void ResetTextSplitVertical()
        {
            TextSplitVertical = DEFAULT_TEXT_SPLIT_VERTICAL;
        }
        #endregion

        #region TextSplitHorizontal
        /// <summary>
        /// Gets and sets the text to use for the split horizontal context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the split horizontal context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("Split &Horizontal")]
        [Localizable(true)]
        public string TextSplitHorizontal
        {
            get { return _textSplitHorizontal; }
            set { _textSplitHorizontal = value; }
        }

        /// <summary>
        /// Resets the TextSplitHorizontal property to its default value.
        /// </summary>
        public void ResetTextSplitHorizontal()
        {
            TextSplitHorizontal = DEFAULT_TEXT_SPLIT_HORIZONTAL;
        }
        #endregion

        #region TextRebalance
        /// <summary>
        /// Gets and sets the text to use for the rebalance context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the rebalance context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("&Rebalance")]
        [Localizable(true)]
        public string TextRebalance
        {
            get { return _textRebalance; }
            set { _textRebalance = value; }
        }

        /// <summary>
        /// Resets the TextRebalance property to its default value.
        /// </summary>
        public void ResetTextRebalance()
        {
            TextRebalance = DEFAULT_TEXT_REBALANCE;
        }
        #endregion

        #region TextMaximize
        /// <summary>
        /// Gets and sets the text to use for the maximize context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the maximize context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("&Maximize")]
        [Localizable(true)]
        public string TextMaximize
        {
            get { return _textMaximize; }
            set { _textMaximize = value; }
        }

        /// <summary>
        /// Resets the TextMaximize property to its default value.
        /// </summary>
        public void ResetTextMaximize()
        {
            TextMaximize = DEFAULT_TEXT_MAXIMIZE;
        }
        #endregion

        #region TextRestore
        /// <summary>
        /// Gets and sets the text to use for the restore context menu item.
        /// </summary>
        [Category("Visuals")]
        [Description("Text to use for the restore context menu item.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue("Res&tore")]
        [Localizable(true)]
        public string TextRestore
        {
            get { return _textRestore; }
            set { _textRestore = value; }
        }

        /// <summary>
        /// Resets the TextRestore property to its default value.
        /// </summary>
        public void ResetTextRestore()
        {
            TextRestore = DEFAULT_TEXT_RESTORE;
        }
        #endregion

        #region ShortcutClose
        /// <summary>
        /// Gets and sets the shortcut for closing the current page.
        /// </summary>
        [Category("Visuals")]
        [Description("Shortcut for closing the current page.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Keys ShortcutClose
        {
            get { return _shortcutClose; }
            set { _shortcutClose = value; }
        }

        /// <summary>
        /// Decide if the shortcut for closing the current page.
        /// </summary>
        /// <returns>True if value should be serialized.</returns>
        protected bool ShouldSerializeShortcutClose()
        {
            return !_shortcutClose.Equals(DEFAULT_SHORTCUT_CLOSE);
        }

        /// <summary>
        /// Resets the ShortcutClose property to its default value.
        /// </summary>
        public void ResetShortcutClose()
        {
            ShortcutClose = DEFAULT_SHORTCUT_CLOSE;
        }
        #endregion

        #region ShortcutCloseAllButThis
        /// <summary>
        /// Gets and sets the shortcut for 'close all but this' page.
        /// </summary>
        [Category("Visuals")]
        [Description("Shortcut for 'close all but this' page.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Keys ShortcutCloseAllButThis
        {
            get { return _shortcutCloseAllButThis; }
            set { _shortcutCloseAllButThis = value; }
        }

        /// <summary>
        /// Decide if the shortcut for 'close all but this' page.
        /// </summary>
        /// <returns>True if value should be serialized.</returns>
        protected bool ShouldSerializeShortcutCloseAllButThis()
        {
            return !_shortcutCloseAllButThis.Equals(DEFAULT_SHORTCUT_CLOSE_ALL_BUT_THIS);
        }

        /// <summary>
        /// Resets the ShortcutCloseAllButThis property to its default value.
        /// </summary>
        public void ResetShortcutCloseAllButThis()
        {
            ShortcutCloseAllButThis = DEFAULT_SHORTCUT_CLOSE_ALL_BUT_THIS;
        }
        #endregion

        #region ShortcutMoveNext
        /// <summary>
        /// Gets and sets the shortcut for moving the current page to the next cell.
        /// </summary>
        [Category("Visuals")]
        [Description("Shortcut for moving the current page to the next cell.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Keys ShortcutMoveNext
        {
            get { return _shortcutMoveNext; }
            set { _shortcutMoveNext = value; }
        }

        /// <summary>
        /// Decide if the shortcut for moving the current page to the next cell.
        /// </summary>
        /// <returns>True if value should be serialized.</returns>
        protected bool ShouldSerializeShortcutMoveNext()
        {
            return !_shortcutMoveNext.Equals(DEFAULT_SHORTCUT_MOVE_NEXT);
        }

        /// <summary>
        /// Resets the ShortcutMoveNext property to its default value.
        /// </summary>
        public void ResetShortcutMoveNext()
        {
            ShortcutMoveNext = DEFAULT_SHORTCUT_MOVE_NEXT;
        }
        #endregion

        #region ShortcutMovePrevious
        /// <summary>
        /// Gets and sets the shortcut for moving the current page to the previous cell.
        /// </summary>
        [Category("Visuals")]
        [Description("Shortcut for moving the current page to the previous cell.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Keys ShortcutMovePrevious
        {
            get { return _shortcutMovePrevious; }
            set { _shortcutMovePrevious = value; }
        }

        /// <summary>
        /// Decide if the shortcut for moving the current page to the previous cell.
        /// </summary>
        /// <returns>True if value should be serialized.</returns>
        protected bool ShouldSerializeShortcutMovePrevious()
        {
            return !_shortcutMovePrevious.Equals(DEFAULT_SHORTCUT_MOVE_PREVIOUS);
        }

        /// <summary>
        /// Resets the ShortcutMovePrevious property to its default value.
        /// </summary>
        public void ResetShortcutMovePrevious()
        {
            ShortcutMovePrevious = DEFAULT_SHORTCUT_MOVE_PREVIOUS;
        }
        #endregion

        #region ShortcutSplitVertical
        /// <summary>
        /// Gets and sets the shortcut for splitting the current page into a vertical aligned page.
        /// </summary>
        [Category("Visuals")]
        [Description("Shortcut for splitting the current page into a vertical aligned page.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Keys ShortcutSplitVertical
        {
            get { return _shortcutSplitVertical; }
            set { _shortcutSplitVertical = value; }
        }

        /// <summary>
        /// Decide if the shortcut for splitting the current page into a vertical aligned page.
        /// </summary>
        /// <returns>True if value should be serialized.</returns>
        protected bool ShouldSerializeShortcutSplitVertical()
        {
            return !_shortcutSplitVertical.Equals(DEFAULT_SHORTCUT_SPLIT_VERTICAL);
        }

        /// <summary>
        /// Resets the ShortcutSplitVertical property to its default value.
        /// </summary>
        public void ResetShortcutSplitVertical()
        {
            ShortcutSplitVertical = DEFAULT_SHORTCUT_SPLIT_VERTICAL;
        }
        #endregion

        #region ShortcutSplitHorizontal
        /// <summary>
        /// Gets and sets the shortcut for splitting the current page into a horizontal aligned page.
        /// </summary>
        [Category("Visuals")]
        [Description("Shortcut for splitting the current page into a horizontal aligned page.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Keys ShortcutSplitHorizontal
        {
            get { return _shortcutSplitHorizontal; }
            set { _shortcutSplitHorizontal = value; }
        }

        /// <summary>
        /// Decide if the shortcut for splitting the current page into a horizontal aligned page.
        /// </summary>
        /// <returns>True if value should be serialized.</returns>
        protected bool ShouldSerializeShortcutSplitHorizontal()
        {
            return !_shortcutSplitHorizontal.Equals(DEFAULT_SHORTCUT_SPLIT_HORIZONTAL);
        }

        /// <summary>
        /// Resets the ShortcutSplitHorizontal property to its default value.
        /// </summary>
        public void ResetShortcutSplitHorizontal()
        {
            ShortcutSplitHorizontal = DEFAULT_SHORTCUT_SPLIT_HORIZONTAL;
        }
        #endregion

        #region ShortcutRebalance
        /// <summary>
        /// Gets and sets the shortcut for rebalancing the layout.
        /// </summary>
        [Category("Visuals")]
        [Description("Shortcut for rebalancing the layout.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Keys ShortcutRebalance
        {
            get { return _shortcutRebalance; }
            set { _shortcutRebalance = value; }
        }

        /// <summary>
        /// Decide if the shortcut for rebalancing the layout.
        /// </summary>
        /// <returns>True if value should be serialized.</returns>
        protected bool ShouldSerializeShortcutRebalance()
        {
            return !_shortcutRebalance.Equals(DEFAULT_SHORTCUT_REBALANCE);
        }

        /// <summary>
        /// Resets the ShortcutRebalance property to its default value.
        /// </summary>
        public void ResetShortcutRebalance()
        {
            ShortcutRebalance = DEFAULT_SHORTCUT_REBALANCE;
        }
        #endregion

        #region ShortcutMaximizeRestore
        /// <summary>
        /// Gets and sets the shortcut for maximizing/restoring the layout.
        /// </summary>
        [Category("Visuals")]
        [Description("Shortcut for maximizing/restoring the layout.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        public Keys ShortcutMaximizeRestore
        {
            get { return _shortcutMaximizeRestore; }
            set { _shortcutMaximizeRestore = value; }
        }

        /// <summary>
        /// Decide if the shortcut for maximizing/restoring the layout.
        /// </summary>
        /// <returns>True if value should be serialized.</returns>
        protected bool ShouldSerializeShortcutMaximizeRestore()
        {
            return !_shortcutMaximizeRestore.Equals(DEFAULT_SHORTCUT_MAXIMIZE_RESTORE);
        }

        /// <summary>
        /// Resets the ShortcutMaximizeRestore property to its default value.
        /// </summary>
        public void ResetShortcutMaximizeRestore()
        {
            ShortcutMaximizeRestore = DEFAULT_SHORTCUT_MAXIMIZE_RESTORE;
        }
        #endregion

        #region ShowContextMenu
        /// <summary>
        /// Gets and sets if a workspace context menu is shown on tab right clicking.
        /// </summary>
        [Category("Visuals")]
        [Description("Determines if a workspace context menu is added on tab right clicking.")]
        [RefreshPropertiesAttribute(RefreshProperties.All)]
        [DefaultValue(true)]
        public bool ShowContextMenu
        {
            get { return _showContextMenu; }
            set { _showContextMenu = value; }
        }
        #endregion
    }
}

﻿#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Syncfusion.UI.Xaml.Core;

namespace Bring_into_View
{
    /// <summary>
    /// Reprsents the class <see cref="Model"/> that contains the data for <see cref="Syncfusion.UI.Xaml.TreeView.TreeViewItem"/>. 
    /// </summary>
    public class Model : NotificationObject
    {
        #region Fields
        /// <summary>
        /// Maintains the collections for models.
        /// </summary>
        private ObservableCollection<Model> models;

        /// <summary>
        /// Maintains the string value for state.
        /// </summary>
        private string state;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Model"/> class.
        /// </summary>
        public Model()
        {
            Models = new ObservableCollection<Model>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the collection for Models.
        /// </summary>
        public ObservableCollection<Model> Models
        {
            get
            {
                return models;
            }

            internal set
            {
                models = value;
                this.RaisePropertyChanged(nameof(Models));
            }
        }
      
        /// <summary>
        /// Gets or sets a value indicating the state of the TreeViewItem.
        /// </summary>
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                this.RaisePropertyChanged(nameof(State));
            }
        }
        #endregion
    }
}

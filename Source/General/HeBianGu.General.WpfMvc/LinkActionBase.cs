﻿using HeBianGu.Base.WpfBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.General.WpfMvc
{
    public class LinkActionBase : NotifyPropertyChanged, ILinkActionBase
    {
        private string _controller;
        /// <summary> 说明  </summary>
        public string Controller
        {
            get { return _controller; }
            set
            {
                _controller = value;
                RaisePropertyChanged("Controller");
            }
        }

        private string _action;
        /// <summary> 说明  </summary>
        public string Action
        {
            get { return _action; }
            set
            {
                _action = value;
                RaisePropertyChanged("Action");
            }
        }

        private string _displayName;
        /// <summary> 说明  </summary>
        public string DisplayName
        {
            get { return _displayName; }
            set
            {
                _displayName = value;
                RaisePropertyChanged("DisplayName");
            }
        }

        private string _logo;
        /// <summary> 说明  </summary>
        public string Logo
        {
            get { return _logo; }
            set
            {
                _logo = value;
                RaisePropertyChanged("Logo");
            }
        }

        public Task<IActionResult> ActionResult()
        {
            return ControllerService.CreateActionResult(this.Controller, this.Action);

        }
    }



}

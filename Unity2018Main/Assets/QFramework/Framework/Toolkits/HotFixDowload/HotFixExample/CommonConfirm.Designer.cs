// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace MyGame
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using UnityEngine;
    using UnityEngine.UI;
    
    
    public partial class CommonConfirm
    {
        
        public const string NAME = "CommonConfirm";
        
        [SerializeField()]
        public UnityEngine.UI.Text Title;
        
        [SerializeField()]
        public UnityEngine.UI.Text HotFixDesText;
        
        [SerializeField()]
        public UnityEngine.UI.Button ConfirmBtn;
        
        [SerializeField()]
        public UnityEngine.UI.Button CancleBtn;
        
        private CommonConfirmData mPrivateData = null;
        
        public CommonConfirmData mData
        {
            get
            {
                return mPrivateData ?? (mPrivateData = new CommonConfirmData());
            }
            set
            {
                mUIData = value;
                mPrivateData = value;
            }
        }
        
        protected override void ClearUIComponents()
        {
            Title = null;
            HotFixDesText = null;
            ConfirmBtn = null;
            CancleBtn = null;
            mData = null;
        }
    }
}

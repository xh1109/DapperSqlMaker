
using System;
using Dapper;
using Dapper.Contrib.Extensions;

namespace FW.Model
{

    /// <summary>
    /// A class which represents the LockPers table.
    /// </summary>
	public partial class LockPers
	{
        /*  Name  Content  Prompt  Id  InsertTime  IsDel  DelTime  */

        //public virtual string Name { get; set; }
        //public virtual string Content { get; set; }
        //      // this.OnPropertyValueChange()  
        //      public virtual string Prompt { get; set; }
        //      字段名为id会默认当作主键   [ExplicitKey]  // 显示键 代码中赋值
        //public virtual string Id { get; set; }
        //public virtual DateTime? InsertTime { get; set; }
        //public virtual string IsDel { get; set; }
        //public virtual DateTime? DelTime { get; set; }
        //      public virtual DateTime? UpdateTime { get; set; }


        public LockPers() {  }
        

        private string _ContentOld;
        [Write(false)]
        public virtual string ContentOld {
            get { return _ContentOld; }
            set {
                _ContentOld = value;
                _WriteFiled.Add(this.GetType().GetProperty("ContentOld") );
            }
        }


    }

    [Table("LockPers")]
    public class LockPers_ : LockPers
    {
        private string _Id { get; set; }
        [ExplicitKey]  // 显示键 代码中赋值
        public override string Id
        {
            set
            {
                _Id = value;
                if (_IsWriteFiled) _WriteFiled.Add(this.GetType().GetProperty(this.Field_Id));
            }
            get { return _Id; }
        }
    }
} // namespace

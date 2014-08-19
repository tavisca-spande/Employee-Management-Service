using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace ValidationForEMS
{
    class CustomBehaviorSection : BehaviorExtensionElement
    {
        private const string EnabledAttributeName = "enabled";

        [ConfigurationProperty(EnabledAttributeName, DefaultValue = true, IsRequired = false)]
        public bool Enabled
        {
            get { return (bool)base[EnabledAttributeName]; }
            set { base[EnabledAttributeName] = value; }
        }

        protected override object CreateBehavior()
        {
            return new ValidationBehavior(this.Enabled);

        }

        public override Type BehaviorType
        {

            get { return typeof(ValidationBehavior); }


        }
    }
}

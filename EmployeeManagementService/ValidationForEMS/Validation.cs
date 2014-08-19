using System.Configuration;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Text.RegularExpressions;

namespace ValidationForEMS
{
    public class Validation : IParameterInspector
    {

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
            
        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            if (operationName == "CreateNewEmployee")
            {
                for (int index = 0; index < inputs.Length; index++)
                {
                    if (index == 0)
                    {
                        
                        if (((int)inputs[index] < 0))
                            throw new FaultException(new FaultReason("Employee ID cannot be negative"), new FaultCode("ID Negative"));      
                           
                    }
                    if (index == 1)
                    {
                        var regexItem = new Regex("^[a-zA-Z]*$");
                        if(!regexItem.IsMatch((string)inputs[index]))
                            throw new FaultException(new FaultReason("No Special Symbols Allowed in Name"), new FaultCode("Name with Special characters"));  
                        
                    }
                }
            }
            if (operationName == "GetEmployeeDetails")
            {
                for (int index = 0; index < inputs.Length; index++)
                {
                    if (index == 0)
                    {

                        if (((int)inputs[index] < 0))
                            throw new FaultException(new FaultReason("Employee ID cannot be negative"), new FaultCode("ID Negative")); 
                    }
                }
            }
            return null;

        }
    }
}

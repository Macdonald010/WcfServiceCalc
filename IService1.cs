using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceCalc
{
    // Define the service contract
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        double Add(double n1, double n2);

        [OperationContract]
        double Subtract(double n1, double n2);

        [OperationContract]
        double Multiply(double n1, double n2);

        [OperationContract]
        double Divide(double n1, double n2);

        [OperationContract]
        double Modulus(double n1, double n2);

        [OperationContract]
        double Logarithm(double n1, double baseValue);

        [OperationContract]
        double Exponential(double baseValue, double exponent);

        [OperationContract]
        double SquareRoot(double n);
    }
}
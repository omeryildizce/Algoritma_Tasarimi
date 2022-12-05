using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c05_interface
{
    public interface ITransfer : IBankaHesap
    {
        bool TransferYap(IBankaHesap aliciHesap, decimal miktar);
    }
}

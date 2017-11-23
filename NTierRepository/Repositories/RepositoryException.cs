using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierRepository.Repositories
{
    public class RepositoryException : Exception
    {
        private string message;
        private string errorCode;
        public String ErrorCode { get => errorCode; }
        public  override String Message { get => message; }
        public RepositoryException() : base()
        {

        }
        public RepositoryException(String code, string message) : base(code + ":" + message)
        {
            errorCode = code;
            this.message = message;


        }
    }
}

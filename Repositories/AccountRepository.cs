using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountByTd(string accountID)
            =>AccountDao.GetAccountByTd(accountID);
    }
}

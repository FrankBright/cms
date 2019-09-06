using CMS.Application.DTO;
using CMS.Domain.UserAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Application.Services
{
    public class UserAppService: IUserAppService
    {
        #region Members

        readonly IUserRepository _userRepository;

        #endregion

        #region Constructor

        /// <summary>
        /// Create a new instance 
        /// </summary>
        public UserAppService(IUserRepository userRepository) // the bank account repository dependency)
        {
            //check preconditions
            if (userRepository == null)
                throw new ArgumentNullException("userRepository");


            _userRepository = userRepository;
        }

        #endregion


        public UserDTO AddBankAccount(UserDTO userDTO)
        {
            if (userDTO != null)
            {
                //check if exists the customer for this bank account
                var associatedCustomer = _customerRepository.Get(bankAccountDTO.CustomerId);

                if (associatedCustomer != null) // if the customer exist
                {
                    //Create a new bank account  number
                    var accountNumber = CalculateNewBankAccountNumber();

                    //Create account from factory 
                    var account = BankAccountFactory.CreateBankAccount(associatedCustomer, accountNumber);

                    //save bank account
                    SaveBankAccount(account);

                    //return dto
                    var adapter = TypeAdapterFactory.CreateAdapter();
                    return adapter.Adapt<BankAccount, BankAccountDTO>(account);
                }
                else //the customer for this bank account not exist, cannot create a new bank account
                {
                    LoggerFactory.CreateLog().LogWarning(Messages.warning_CannotCreateBankAccountForNonExistingCustomer);
                    return null;
                }
            }
            else // if bank account is null or customer identifier  is empty, cannot create a new bank account
            {
                LoggerFactory.CreateLog().LogWarning(Messages.warning_CannotAddNullBankAccountOrInvalidCustomer);
                return null;
            }
        }
    }
}

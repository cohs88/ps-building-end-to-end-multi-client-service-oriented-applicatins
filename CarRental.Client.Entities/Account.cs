﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Common.Core;

namespace CarRental.Client.Entities
{
    public class Account : ObjectBase
    {
        private int _AccountId;
        private string _LoginEmail;
        private string _FirstName;
        private string _LastName;
        private string _Address;
        private string _City;
        private string _State;
        private string _ZipCode;
        private string _CreditCard;
        private string _ExpDate;

        public string ExpDate
        {
            get { return _ExpDate; }
            set {
                if (_ExpDate != value)
                {
                    _ExpDate = value;
                    OnPropertyChanged(() => ExpDate);
                }
            }
        }


        public string CreditCard
        {
            get { return _CreditCard; }
            set {
                if (_CreditCard != value)
                {
                    _CreditCard = value;
                    OnPropertyChanged(() => CreditCard);
                }
            }
        }


        public string ZipCode
        {
            get { return _ZipCode; }
            set {
                if (_ZipCode != value)
                {
                    _ZipCode = value;
                    OnPropertyChanged(() => ZipCode);
                }
            }
        }


        public string State
        {
            get { return _State; }
            set {
                if (_State != value)
                {
                    _State = value;
                    OnPropertyChanged(() => State);
                }
            }
        }


        public string City
        {
            get { return _City; }
            set {
                if (_City != value)
                {
                    _City = value;
                    OnPropertyChanged(() => City);
                }
            }
        }


        public string Address
        {
            get { return _Address; }
            set {
                if (_Address != value)
                {
                    _Address = value;
                    OnPropertyChanged(() => Address);
                }
            }
        }


        public string LastName
        {
            get { return _LastName; }
            set {
                if (_LastName != value)
                {
                    _LastName = value;
                    OnPropertyChanged(() => LastName);
                }
            }
        }


        public string FirstName
        {
            get { return _FirstName; }
            set {
                if (_FirstName != value)
                {
                    _FirstName = value;
                    OnPropertyChanged(() => FirstName);
                }
            }
        }


        public string LoginEmail
        {
            get { return _LoginEmail; }
            set {
                if (_LoginEmail != value)
                {
                    _LoginEmail = value;
                    OnPropertyChanged(() => LoginEmail);
                }
            }
        }


        public int AccountId
        {
            get { return _AccountId; }
            set {
                if (_AccountId != value)
                {
                    _AccountId = value;
                    OnPropertyChanged(() => AccountId);
                }
            }
        }

    }
}

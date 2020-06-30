﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic 
    {
        protected IDataRepository<SystemLanguageCodePoco> _repository;

        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository)
        {
            _repository = repository;
        }

        public SystemLanguageCodePoco Get(string languageId)
        {
            return _repository.GetSingle(c => c.LanguageID == languageId);
        }

        public void Add(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            _repository.Add(pocos);

        }

        public void Update(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            _repository.Update(pocos);

        }

        public void Delete(SystemLanguageCodePoco[] pocos)
        {
            _repository.Remove(pocos);
        }

        public List<SystemLanguageCodePoco> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        private void Verify(SystemLanguageCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (SystemLanguageCodePoco poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.LanguageID))
                {
                    exceptions.Add(new ValidationException(1000, "Language ID can not be blank"));
                }
                if (string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(1001, "Name can not be blank"));
                }
                if (string.IsNullOrEmpty(poco.NativeName))
                {
                    exceptions.Add(new ValidationException(1002, "Native name can not be blank"));
                }
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }

        }

    }
}

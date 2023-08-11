using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskLetters.Models
{
    public class IncomingLetter : BaseLetter
    {
        public IncomingLetter()
        {
            Id = 0;
            LetterKind = "";
            Name = "";
            Subject = "";
            CreatedDate = SqlDateTime.Null;
            DocumentNumber = "";
            LetterKindGuid = SqlGuid.Null;
            AddresseeId = 0;
            CounterpartyId = 0;
            DeliveryMethodId = 0; 
            OrganisationId = 0;
        }

        public IncomingLetter(string name, string subject, string documentNumber) : base(name, subject, documentNumber)
        {
            Id = 0;
            LetterKind = "";
            Name = name;
            Subject = subject;
            CreatedDate = SqlDateTime.Null;
            DocumentNumber = documentNumber;
            LetterKindGuid = SqlGuid.Null;
            AddresseeId = 0;
            CounterpartyId = 0;
            DeliveryMethodId = 0;
            OrganisationId = 0;
        }

        public IncomingLetter(int id, string letterKind, string name, string subject, SqlDateTime createdDate, string documentNumber, SqlGuid letterKindGuid, int addresseeId, int deliveryMethodId, int organisationId, int counterpartyId) 
            : base(id, letterKind, name, subject, createdDate, documentNumber, letterKindGuid)
        {
            Id = id;
            LetterKind = letterKind;
            Name = name;
            Subject = subject;
            CreatedDate = createdDate;
            DocumentNumber = documentNumber;
            LetterKindGuid = letterKindGuid;
            AddresseeId = addresseeId;
            CounterpartyId = counterpartyId;
            DeliveryMethodId = deliveryMethodId;
            OrganisationId = organisationId;
        }

        /// <summary>
        /// Внешний ключ получателя
        /// </summary>
        public int AddresseeId { get; set; }
        /// <summary>
        /// Внешний ключ организации (которой отправили письмо)
        /// </summary>
        public int CounterpartyId { get; set; }
        /// <summary>
        /// Внешний ключ способа отправки
        /// </summary>
        public int DeliveryMethodId { get; set; }
        /// <summary>
        /// Внешний ключ организации (которая отправила письмо)
        /// </summary>
        public int OrganisationId { get; set; }
    }
}

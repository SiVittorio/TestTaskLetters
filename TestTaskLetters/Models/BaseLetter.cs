using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestTaskLetters.Models
{
    /// <summary>
    /// Класс базового письма
    /// </summary>
    public class BaseLetter
    {
        public BaseLetter()
        {
            Id = 0;
            LetterKind = "";
            Name = "";
            Subject = "";
            CreatedDate = SqlDateTime.Null;
            DocumentNumber = "";
            LetterKindGuid = SqlGuid.Null;
        }

        public BaseLetter(string name, string subject, string documentNumber)
        {
            Id = 0;
            LetterKind = "";
            Name = name;
            Subject = subject;
            CreatedDate = SqlDateTime.Null;
            DocumentNumber = documentNumber;
            LetterKindGuid = SqlGuid.Null;
        }

        public BaseLetter(int id, string letterKind, string name, string subject, SqlDateTime createdDate, string documentNumber, SqlGuid letterKindGuid)
        {
            Id = id;
            LetterKind = letterKind;
            Name = name;
            Subject = subject;
            CreatedDate = createdDate;
            DocumentNumber = documentNumber;
            LetterKindGuid = letterKindGuid;
        }

        /// <summary>
        /// Первичный ключ
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование вида документа
        /// </summary>
        public string LetterKind { get; set; }
        /// <summary>
        /// Имя документа
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Содержание документа
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Дата создания документа
        /// </summary>
        public SqlDateTime CreatedDate { get; set; }
        /// <summary>
        /// Номер документа
        /// </summary>
        public string DocumentNumber { get; set; }
        /// <summary>
        /// Guid вида документа
        /// </summary>
        public SqlGuid LetterKindGuid { get; set; }
    }
}

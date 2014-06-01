namespace Boom_Manager_Project.DataBaseClasses
{
    class ErrorsAndWarningsMessages
    {
        private static ErrorsAndWarningsMessages _errorsAndWarningsMessages;

        public static ErrorsAndWarningsMessages ErrorsAndWarningsInstance()
        {
            return _errorsAndWarningsMessages ?? (_errorsAndWarningsMessages = new ErrorsAndWarningsMessages());
        }

        public string GetError(int errorId)
        {
            string error;
            switch (errorId)
            {
                case 1:
                    error = "НЕТ СОЕДИНЕНИЯ С ДЕВАЙСОМ!\nПерезагрузите девайс и попробуйте снова!";//"NO CONNECTION WITH DEVICE!\nPlease reboot device and try again.";
                    break;
                case 2:
                    error = "Невозможно удалить все цены временной зоны!";//"Cannot delete all prices of timezone ";
                    break;
                case 3:
                    error = "Невозможно обновить базу данных во время закрытия комментариев сессии!\nПожалуйста обратитесь к разработчику!";//"Can't update DataBase during closing client comments! Please contact with Developer";
                    break;
                case 4:
                    error = "Невозможно отнять сумму с карточки клиента с ID: ";//"Cannot substract sum from client card with ID ";
                    break;
                case 5:
                    error = "Невозможно продлить сессию!";//"Cannot extend sesion time!";
                    break;
                case 6:
                    error = "Невозможно внести новую запись временной зоны в базу данных!";//"Can not insert new timezone to database!";
                    break;
                case 7:
                    error = "Невозможно внести данные цены временной зоны!";//"Cannot insert price data of TimeZone to database";
                    break;
                case 8:
                    error = "Какие-то данные введены неверно! Проверьте введенные данные!";//"Something wrong! Check the entered data!";
                    break;
                case 9:
                    error = "Поля заполнены неправильно! Проверьте введенные данные!";//"Some fields have wrog values! Check entered data and try again.";
                    break;
                case 10:
                    error = "Неверные логин или пароль!";//"Login or Password is wrong!";
                    break;
                case 11:
                    error = "Поясните полностью причину(проблему) выключения!";//"Input full and understandable reason,\nwhy you want to switch off console before time expires! ";
                    break;
                case 12:
                    error = "Only manager have an access to this field!\nОшибка№12!";
                    break;
                default:
                    error = "Неизвестная оценка!";//"Unknown error!";
                    break;
            }
            return error;
        }

        public string GetWarning(int warningId)
        {
            string warning;
            switch (warningId)
            {
                case 1:
                    warning = "Предупреждение!";//"Warning!";
                    break;
                case 2:
                    warning = " будет удалена с базы данных!\nВы уверены?";//" will be removed from DataBase!\nAre you sure?";
                    break;
                case 3:
                    warning = "Отчет был успешно сформирован.\nХотите его открыть?";//"Report was successfully generated.\nWould younlike to open generated report?";
                    break;
                case 4:
                    warning = "Почему вы хотите закрыть сессию раньше времени?";//"Why do you want to close session\nbefore time expires?";
                    break;
                case 5:
                    warning = "Введите логин и пароль чтобы продолжить!";//"Enter login and password to continue!";
                    break;
                case 6:
                    warning = "Ошибка!";
                    break;
                default:
                    warning = "Неизвестное предупреждение!";//"Unknown warning!";
                    break;
            }
            return warning;
        }
        public string GetCaption(int captionId)
        {
            string caption;
            switch (captionId)
            {
                case 1:
                    caption = "Предупрездение!";//"Attention!";
                    break;
                default:
                    caption = "Неизвестный заголовок!";//"Unknown caption";
                    break;
            }
            return caption;
        }
    }
}

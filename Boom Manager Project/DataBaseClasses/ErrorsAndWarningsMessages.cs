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
                    error = "Только менеджер имеет право доступа к этому функционалу! Ошибка 12!";//"Only manager have an access to this field!\nОшибка № 12!";
                    break;
                case 13:
                    error = "Ошибка при открытии! Возможно этот файл уже открыт и не может быть изменен!";
                    break;
                case 14:
                    error =
                        "Ошибка! Сессия не может быть закрыта из-за отсутствия клиентов в ней!\nОбратитесь к разработчику!";//"Error! Session cannot be closed because of client absence in the session#";
                    break;
                case 15:
                    error = "Недостаточно средств на карте чтобы расплатиться!\nПожалуйста закиньте больше денег на карту c ID: ";//"Insufficient money on card!\nPlease put more money on card(s) with id#"
                    break;
                case 16:
                    error = " или добавьте еще одну карточку!";
                    break;
                case 17:
                    error = "Недостаточно денег для оплаты минимального времени!";//"Insufficient money to play minimum one hour!"
                    break;
                case 18:
                    error = "Невозможно занести новую запись DaySession! Обратитесь к разработчику!";//"Cannot insert DaySession!"
                    break;
                case 19:
                    error = "Невозможно занести новую запись или обновить Cash! Обратитесь к разработчику!";//"Cannot update cash"
                    break;
                case 20:
                    error = "Невозможно обновить запись в базе данных playstation_state! Обратитесь к разработчику!";//"Cannot update playstation state!"
                    break;
                case 21:
                    error = "Невозможно внести новую запись в базу данных clients_per_session! Обратитесь к разработчику!";//"Cannot insert clients in clients_per_session table!"
                    break;
                case 22:
                    error = "Невозможно получить цену данной консоли!";//"Can't get playstation cost."
                    break;
                case 23:
                    error = "Клиенты отсутствуют в базе данных! Добавьте клиентов в базу данных чтобы использовать скидки!";
                    break;
                case 24:
                    error = "Клиент отсутствует в базе данных! Проверьте считываемую карту!";
                    break;
                case 25:
                    error = "Введенная приставка отсутствует в базе данных, или уже занята! Попробуйте выбрать свободную.";
                    break;
                case 26:
                    error = "Заполните все поля корректно!";
                    break;
                case 27:
                    error = "Ошибка! Уровень с таким названием уже существует!";
                    break;
                case 28:
                    error = "Ошибка! Уровень с таким названием не найден!";
                    break;
                case 29:
                    error = "Ошибка! Некоректное название уровня! Удаление не было выполнено!";
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
                case 7:
                    warning = " сом осталось!\nКлиент забрал сдачу?";//" soms left.\nWere money returned to client?";
                    break;
                case 8:
                    warning = " сом было возвращено!";//" soms were returned";
                    break;
                default:
                    warning = "Неизвестное предупреждение!";//"Unknown warning!";
                    break;
            }
            return warning;
        }

        public string GetMessage(int messageId)
        {
            string result = "";
            switch (messageId)
            {
                case 0:
                    result = "Смена успешно принята!";//"Shift accepted successfully!";
                    break;
                default:
                    result = "Unknown message!";
                    break;
            }
            return result;
        }

        public string GetCaption(int captionId)
        {
            string caption;
            switch (captionId)
            {
                case 1:
                    caption = "Предупрездение!";//"Attention!";
                    break;
                case 2:
                    caption = "Вопрос";//"Question";
                    break;
                default:
                    caption = "Неизвестный заголовок!";//"Unknown caption";
                    break;
            }
            return caption;
        }
    }
}

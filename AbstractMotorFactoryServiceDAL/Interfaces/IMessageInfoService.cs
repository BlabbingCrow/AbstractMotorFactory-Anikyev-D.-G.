﻿using AbstractMotorFactoryServiceDAL.BindingModels;
using AbstractMotorFactoryServiceDAL.ViewModels;
using AbstractMotorFactoryServiceDAL.Attributies;
using System.Collections.Generic;

namespace AbstractMotorFactoryServiceDAL.Interfaces
{
    [CustomInterface("Интерфейс для работы с письмами")]
    public interface IMessageInfoService
    {
        [CustomMethod("Метод получения списка писем")]
        List<MessageInfoViewModel> GetList();

        [CustomMethod("Метод получения письма по id")]
        MessageInfoViewModel GetElement(int id);

        [CustomMethod("Метод добавления письма")]
        void AddElement(MessageInfoBindingModel model);
    }
}

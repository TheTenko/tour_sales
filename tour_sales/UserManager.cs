using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace tour_sales
{
    public static class UserManager
    {
        private static string filePath = "users.json";

        public static bool RegisterUser(User newUser)
        {
            List<User> users = new List<User>();

            // Если файл уже существует — считываем пользователей
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json);
            }

            // Проверка на уникальность логина или почты
            if (users.Any(u => u.Login == newUser.Login || u.Mail == newUser.Mail))
            {
                return false; // Такой пользователь уже есть
            }

            // Добавляем нового пользователя
            users.Add(newUser);

            // Сохраняем обратно в файл
            string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);

            return true;
        }
        public static bool Authenticate(string login, string password)
        {
            // Загружаем пользователей из JSON
            List<User> users = new List<User>();

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<List<User>>(json);
            }

            // Ищем пользователя с таким логином и проверяем пароль
            var user = users.FirstOrDefault(u => u.Login == login && u.Password == password);
            return user != null; // Если нашли такого пользователя, возвращаем true
        }
    }
}

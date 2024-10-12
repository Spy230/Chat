# Чат-клиент на WCF

## Описание

Чат-клиент на WCF для обмена сообщениями в реальном времени. Приложение позволяет пользователям подключаться к серверу, отправлять и получать сообщения, создавая простой и интуитивно понятный интерфейс для общения. Реализована поддержка нескольких пользователей, что позволяет взаимодействовать с другими участниками чата в режиме реального времени.

## Стек технологий

- **WCF (Windows Communication Foundation)**: для реализации обмена сообщениями.
- **C#**: язык программирования для разработки приложения.
- **XAML**: для создания пользовательского интерфейса.

## Пример работоспособности

1. Запуск хоста (хост запускается от имени администратора):  
   <p align="center">
   <img src="https://github.com/user-attachments/assets/85e307d1-af09-4586-b650-62473996512a" alt="Запуск хоста" width="600">
   </p>

2. При запуске приложения пользователь вводит свое имя в текстовом поле:  
   <p align="center">
   <img src="https://github.com/user-attachments/assets/7f08c6c1-1e8d-4366-8794-f920d6b92a9b" alt="Ввод имени" width="600">
   <img src="https://github.com/user-attachments/assets/fafb8ba2-25c0-4f2a-a26d-cf87b06d3900" alt="Ввод имени" width="600">
   </p>

3. Пользователь нажимает кнопку "Connect" для подключения к чату:  
   <p align="center">
   <img src="https://github.com/user-attachments/assets/8ca5c84c-f644-4609-b670-8baf6950b85e" alt="Кнопка Connect" width="600">
   <img src="https://github.com/user-attachments/assets/a44795cd-1c68-4292-9e50-3464a9aa301d" alt="Кнопка Connect" width="600">
   </p>

4. После подключения пользователь может отправлять сообщения:  
   <p align="center">
   <img src="https://github.com/user-attachments/assets/90432d0c-8154-4d09-a8fd-5e24d547cbec" alt="Отправка сообщений" width="600">
   <img src="https://github.com/user-attachments/assets/6c4ea6a0-6464-4957-92ce-c3f84f139d44" alt="Отправка сообщений" width="600">
   </p>

5. Пользователь может отключиться от чата, нажав кнопку "Disconnect":  
   <p align="center">
   <img src="https://github.com/user-attachments/assets/aaeab3ef-46a0-4214-8a59-a28fc42aa947" alt="Кнопка Disconnect" width="600">
   </p>

## Запуск в сети

Если необходимо запустить чат не локально, а в сети, необходимо выполнить следующие шаги:

1. Откройте файл `App.config` в проекте.
2. Найдите строку, где указан IP-адрес сервера:  
   <p align="center">
   <img src="https://github.com/user-attachments/assets/f9d47e67-c0f5-4ad3-8bc1-31e75eda1725" alt="IP-адрес сервера" width="600">
   </p>
3. Замените текущий IP-адрес на адрес вашего сервера.

## Установка

1. Склонируйте репозиторий:
   ```bash
   git clone https://github.com/Spy230/Chat.git

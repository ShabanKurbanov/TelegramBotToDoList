```mermaid
flowchart TD
    Client[Клиент] -->|HTTP| API[API Gateway]
    API --> Auth[Аутентификация]
    API --> Product[Сервис товаров]
    API --> Order[Сервис заказов]
    Order --> Payment[Оплата]
    Payment --> BankGateway[Банк]

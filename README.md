
# UniversityDbApp

## Жобаның мақсаты
ASP.NET Core MVC және Entity Framework Core технологияларын пайдаланып, университеттің кафедралары мен оқытушылары туралы мәліметтерді сақтайтын дерекқор құру.

## Қолданылған технологиялар
- C#
- ASP.NET Core MVC
- Entity Framework Core 10
- SQL Server
- Code First
- Git және GitHub

## Дерекқор құрылымы

### Department
- Id – кафедраның бірегей идентификаторы
- Name – кафедра атауы

### Teacher
- Id – оқытушының бірегей идентификаторы
- FullName – оқытушының аты-жөні
- Subject – оқытатын пәні
- DepartmentId – кафедраның сыртқы кілті (Foreign Key)

## Байланыс түрі
Жобада One-to-Many байланысы қолданылған.

Бір кафедрада бірнеше оқытушы жұмыс істей алады, ал әр оқытушы бір кафедраға тиесілі.

## Entity Framework Core
- AppDbContext арқылы дерекқормен байланыс орнатылды.
- Code First тәсілі қолданылды.
- InitialDb миграциясы құрылды.
- SQL Server-де UniversityDb дерекқоры жасалды.

## Іске қосу
1. Репозиторийді жүктеп алу.
2. Connection String параметрін appsettings.json файлында баптау.
3. Терминалда миграцияларды орындау:

```powershell
dotnet ef database update
```

4. Жобаны іске қосу:

```powershell
dotnet run
```

## Автор
aiaruzeksenbek-ops

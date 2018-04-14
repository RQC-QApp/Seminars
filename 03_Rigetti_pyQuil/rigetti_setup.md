## Rigetti Forest

Для работы с квантовым набором инструментов от Rigetti необходимо запросить API key на сайте [Forest](https://www.rigetti.com/index.php/forest)'a: `Ввести своё имя` -> `Ввести свою почту` -> `EMAIL API KEY`.

Затем необходимо выполнить следующую команду, которая запросит ключ и идентификатор пользователя: `pyquil-config-setup`.

Второй вариант - вручную внести эту информацию в файл `~/.pyquil_config`, которая должна иметь следующую форму:

```
[Rigetti Forest]
key: <Rigetti Forest API key>
user_id: <Rigetti User ID>
```

Источник: http://pyquil.readthedocs.io/en/latest/start.html#connecting-to-the-rigetti-forest

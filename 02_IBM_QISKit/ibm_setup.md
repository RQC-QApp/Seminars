## IBM Q Experience

Для запуска программ на локальном квантовом симуляторе ("local_qasm_simulator") следующая настройка не является обязательно.

Но чтобы запустить программу на реальном квантовом чипе в облаке - необходимо наличие файла `Qconfig.py`, в котором должно находиться следующее:

```python
    APItoken = <YOUR API TOKEN>

    config = {
        'url': 'https://quantumexperience.ng.bluemix.net/api',
        # The following should only be needed for IBM Q users.
        'hub': 'MY_HUB',
        'group': 'MY_GROUP',
        'project': 'MY_PROJECT'
    }
```

Токен необходимо взять на сайте [IBM Q Experience](https://quantumexperience.ng.bluemix.net): `My Account` -> `Advanced` -> `Copy API Token` (либо же сначала `Regenerate`).

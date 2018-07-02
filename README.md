## Введение в квантовые вычисления. Семинары <img src="img/rqc.png" href='http://rqc.ru/' width='15%' align='right'>

### Содержание
- Введение:
    1. [[intro_to_qc.ipynb](01_Introduction/intro_to_qc.ipynb)]
        - Основные понятия из линейной алгебры
        - Принципы квантовой механики
- Вычисления с помощью [QISKit](https://qiskit.org)'a и облачной платформы [IBM Q Experience](https://quantumexperience.ng.bluemix.net):
    1. Настройка соединения с API сервисов IBMQX: [[ibm_setup.md](02_IBM_QISKit/ibm_setup.md)]
    2. [[ibm_intro.ipynb](02_IBM_QISKit/ibm_intro.ipynb)]
        - Базовые операции, гейты
        - Представление результатов
- Вычисления с помощью [pyQuil](http://pyquil.readthedocs.io)'a, [Grove](http://grove-docs.readthedocs.io) и облачной платформы [Forest](https://www.rigetti.com/forest) от [Rigetti](https://www.rigetti.com):
    1. Настройка соединения с API сервисов Rigetti Forest: [[rigetti_setup.md](03_Rigetti_pyQuil/rigetti_setup.md)]
    2. [[rigetti_intro.ipynb](03_Rigetti_pyQuil/rigetti_intro.ipynb)]
        - Базовые операции, гейты
        - Представление результатов
- Вычисления с помощью Q# -- квантового языка программирования от Microsoft:
    1. Настройка среды разработки [[microsoft_setup.md for MacOS](04_Microsoft_QSharp/microsoft_setup.md)]
    2. Состояние Белла [[BellState](04_Microsoft_QSharp/BellState)]


### Зависимости

Для работы с семинарами необходимо наличие следующих Python-пакетов:

- [NumPy](http://www.numpy.org) >=1.13.3
- [SciPy](https://scipy.org) >=1.0.0
- [pyQuil](http://pyquil.readthedocs.io) >=1.6.2
- [QISKit](https://qiskit.org) >=0.4.9

Можно установить командой:
```
$ pip install -r requirements.txt
```

А также потребуются Visual Studio Code и .NET-пакеты (для языка программирования Q# от Microsoft).

### Авторы

Антон Каразеев, &lt;YOUR NAME COULD BE HERE&gt;

Помощь приветствуется - сделай [форк](https://guides.github.com/activities/forking/) этого репозитория, а затем запроси [PR](https://help.github.com/articles/about-pull-requests/) 🙂

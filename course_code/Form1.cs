using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace course_code
{
    public partial class Form1 : Form
    {
        // Структура для данных
        struct Discipline
        {
            public string SpecializationCode; // шифр специальности
            public string DisciplineName;     // наименование дисциплины  
            public string DepartmentCode;     // шифр кафедры [БукваЦифраЦифра]
            public int Lectures;              // количество лекций
            public int Practices;             // количество практик
            public int Laboratories;          // количество лабораторных
            public int Sign;                  // признак: 2-экзамен, 1-зачет, 0-ничего

            public override string ToString() =>
                $"{SpecializationCode};{DisciplineName};{DepartmentCode};{Lectures};{Practices};{Laboratories};{Sign}";
        }

        private List<Discipline> disciplines = [];
        private string dataFilePath = "plan.dat";
        private int currentIndex = -1;
        private bool isEditMode = false;

        public Form1()
        {
            InitializeComponent();
            LoadData();
            UpdateDataGridView();
            SetEditMode(false);
        }


        // Загрузка данных из файла
        private void LoadData()
        {
            try
            {
                if (File.Exists(dataFilePath)) //если файл есть
                {
                    disciplines.Clear(); //очиста но по идеи массив и так пустой по умолчанию
                    foreach (string line in File.ReadAllLines(dataFilePath))
                    {
                        string[] parts = line.Split(';');
                        if (parts.Length == 7) //защита от левых строк
                        {
                            Discipline discipline = new Discipline
                            {
                                SpecializationCode = parts[0],
                                DisciplineName = parts[1],
                                DepartmentCode = parts[2],
                                Lectures = int.Parse(parts[3]),
                                Practices = int.Parse(parts[4]),
                                Laboratories = int.Parse(parts[5]),
                                Sign = int.Parse(parts[6])
                            };
                            disciplines.Add(discipline);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Сохранение данных в файл
        private void SaveData()
        {
            try
            {
                List<string> lines = [];
                foreach (Discipline discipline in disciplines)
                {
                    lines.Add(discipline.ToString());
                }
                File.WriteAllLines(dataFilePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обновление DataGridView
        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();
            foreach (Discipline discipline in disciplines)
            {
                dataGridView1.Rows.Add(
                    discipline.SpecializationCode,
                    discipline.DisciplineName,
                    discipline.DepartmentCode,
                    discipline.Lectures,
                    discipline.Practices,
                    discipline.Laboratories,
                    GetSignDescription(discipline.Sign) //без get вернет цифру признака что не очень удобно
                );
            }
        }

        // Получение описания признака
        private string GetSignDescription(int sign)
        {
            return sign switch
            {
                2 => "Экзамен",
                1 => "Зачет",
                0 => "Нет",
                _ => "Неизвестно"
            };
        }

        // Получение числового значения признака из описания нужно для сохранения в файл в теории можно было бы сохранять прямо все слово 
        private int GetSignValue(string description)
        {
            return description switch
            {
                "Экзамен" => 2,
                "Зачет" => 1,
                "Нет" => 0,
                _ => 0
            };
        }

        
        // Переключение режима редактирования
        private void SetEditMode(bool editMode)
        {
            //По умолчанию editMode = false
            // Кнопки редактирования записи
            isEditMode = editMode;
            groupBoxEdit.Visible = editMode;
            btnSave.Enabled = editMode;
            btnCancel.Enabled = editMode;
            btnAdd.Enabled = !editMode;
            btnEdit.Enabled = !editMode && dataGridView1.SelectedRows.Count > 0;
            btnDelete.Enabled = !editMode && dataGridView1.SelectedRows.Count > 0;

            // Кнопки запросов
            btnQuery1.Enabled = !editMode && dataGridView1.SelectedRows.Count > 0;
            btnQuery2.Enabled = !editMode && dataGridView1.SelectedRows.Count > 0;
            btnQuery3.Enabled = !editMode && dataGridView1.SelectedRows.Count > 0;
            btnQuery4.Enabled = !editMode && dataGridView1.SelectedRows.Count > 0;
        }

        // Очистка полей ввода
        private void ClearFields()
        {
            txtSpecializationCode.Text = "";
            txtDisciplineName.Text = "";
            txtDepartmentCode.Text = "";
            numLectures.Value = 0;
            numPractices.Value = 0;
            numLaboratories.Value = 0;
            cmbSign.SelectedIndex = 0;
        }

        // Заполнение полей ввода данными выбранной записи
        private void FillFields(int index)
        {
            if (index >= 0 && index < disciplines.Count)
            {
                Discipline discipline = disciplines[index];
                txtSpecializationCode.Text = discipline.SpecializationCode;
                txtDisciplineName.Text = discipline.DisciplineName;
                txtDepartmentCode.Text = discipline.DepartmentCode;
                numLectures.Value = discipline.Lectures;
                numPractices.Value = discipline.Practices;
                numLaboratories.Value = discipline.Laboratories;
                cmbSign.SelectedIndex = discipline.Sign;
            }
        }

        // ===== ОБРАБОТЧИКИ СОБЫТИЙ =====

        // Добавление новой записи
        private void btnAdd_Click(object sender, EventArgs e)
        {
            currentIndex = -1;
            ClearFields();
            SetEditMode(true);
        }

        // Редактирование записи
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //эта проверка в целом не нужна, т.к в setedit кнопка все равно не активна без колонок ну пусть будет
            {
                currentIndex = dataGridView1.SelectedRows[0].Index;
                FillFields(currentIndex);
                SetEditMode(true);
            }
        }

        // Удаление записи
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) //эта проверка в целом не нужна, т.к в setedit кнопка все равно не активна без колонок ну пусть будет
            {
                int index = dataGridView1.SelectedRows[0].Index;
                string disciplineName = disciplines[index].DisciplineName;

                DialogResult result = MessageBox.Show(
                    $"Вы уверены, что хотите удалить дисциплину \"{disciplineName}\"?",
                    "Подтверждение удаления",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    disciplines.RemoveAt(index);
                    UpdateDataGridView();
                    SaveData();
                }
            }
        }

        // Сохранение записи
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Проверка валидности данных
            if (string.IsNullOrWhiteSpace(txtSpecializationCode.Text) || //не пустое и не пробел проверка
                string.IsNullOrWhiteSpace(txtDisciplineName.Text) ||
                string.IsNullOrWhiteSpace(txtDepartmentCode.Text))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка формата шифра кафедры [БукваЦифраЦифра]
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDepartmentCode.Text, @"^[A-Za-zА-Яа-я]\d{2}$"))
            {
                MessageBox.Show("Шифр кафедры должен быть в формате [БукваЦифраЦифра]!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Создание новой записи
            Discipline discipline = new Discipline
            {
                SpecializationCode = Regex.Replace(txtSpecializationCode.Text.Trim(), @"\s+", " "), //убераю пробелы между словами лишнии до и после тоже
                DisciplineName = Regex.Replace(txtDisciplineName.Text.Trim(), @"\s+", " "), //убераю пробелы между словами лишнии
                DepartmentCode = txtDepartmentCode.Text.Trim().ToUpper(),
                Lectures = (int)numLectures.Value,
                Practices = (int)numPractices.Value,
                Laboratories = (int)numLaboratories.Value,
                Sign = cmbSign.SelectedIndex
            };

            // Добавление или обновление записи без этого будет только добавлять новое а не обновлять
            if (currentIndex == -1)
            {
                disciplines.Add(discipline);
            }
            else
            {
                disciplines[currentIndex] = discipline;
            }

            UpdateDataGridView();
            SaveData();
            SetEditMode(false);
        }

        // Отмена редактирования
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetEditMode(false);
        }

        // Выбор строки в DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = dataGridView1.SelectedRows.Count > 0;
            btnDelete.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        // ===== ОБРАБОТКА ЗАПРОСОВ =====

        // Запрос 1: Общее количество проводимых занятий по кафедре
        private void btnQuery1_Click(object sender, EventArgs e)
        {
            string departmentCode = Interaction.InputBox(
                "Введите шифр кафедры:", "Запрос - Занятия кафедры");

            if (!string.IsNullOrWhiteSpace(departmentCode))
            {
                int totalClasses = disciplines
                    .Where(d => d.DepartmentCode.Equals(departmentCode.Trim(), StringComparison.OrdinalIgnoreCase))
                    .Sum(d => d.Lectures + d.Practices + d.Laboratories);

                MessageBox.Show($"Кафедра {departmentCode} проводит {totalClasses} занятий.",
                              "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
 
        // Запрос 2: Список дисциплин для специальности
        private void btnQuery2_Click(object sender, EventArgs e)
        {
            string specializationCode = Interaction.InputBox(
                "Введите шифр специальности:", "Запрос - Дисциплины специальности");

            if (!string.IsNullOrWhiteSpace(specializationCode))
            {
                specializationCode = Regex.Replace(specializationCode.Trim(), @"\s+", " ");
                var specializationDisciplines = disciplines
                    .Where(d => d.SpecializationCode.Equals(specializationCode.Trim(), StringComparison.OrdinalIgnoreCase))
                    .Select(d => d.DisciplineName)
                    .ToList();

                if (specializationDisciplines.Any()) //если в последовательности что-то есть
                {
                    string result = string.Join("\n", specializationDisciplines);
                    MessageBox.Show($"Дисциплины специальности {specializationCode}:\n\n{result}",
                                  "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Для специальности {specializationCode} дисциплины не найдены.",
                                  "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // Запрос 3: Суммарное количество лекций по кафедрам 
        private void btnQuery3_Click(object sender, EventArgs e)
        {
            var lecturesByDepartment = disciplines
                .GroupBy(d => d.DepartmentCode) //групируем по коду департамента в последовательность где ключ это шифр кафедры
                .Select(g => new { Department = g.Key, TotalLectures = g.Sum(d => d.Lectures) }) //объект с двумя полями шифр и сумма по  всем лекциям кафедры
                .OrderByDescending(x => x.TotalLectures) //сортировка по убыванию по итоговой сумме лекций
                .ToList();

            if (lecturesByDepartment.Any())
            {
                string result = string.Join("\n", lecturesByDepartment.Select(x =>
                    $"{x.Department}: {x.TotalLectures} лекций"));
                MessageBox.Show($"Суммарное количество лекций по кафедрам:\n\n{result}",
                              "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Данные о лекциях не найдены.",
                              "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ну или так
        //var dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

        //foreach (var d in disciplines)
        //{
        //    if (dict.ContainsKey(d.DepartmentCode))
        //        dict[d.DepartmentCode] += d.Lectures;
        //    else
        //        dict[d.DepartmentCode] = d.Lectures;
        //}

        //// сортируем без LINQ: копируем в List<KeyValuePair> и сортируем вручную
        //var pairs = new List<KeyValuePair<string, int>>(dict);
        //pairs.Sort((a, b) => b.Value.CompareTo(a.Value)); // убывание

        //// формируем строку
        //var lines = new List<string>(pairs.Count);
        //foreach (var p in pairs)
        //    lines.Add($"{p.Key}: {p.Value} лекций");

        //MessageBox.Show(string.Join("\n", lines));

        // Запрос 4: Список дисциплин кафедры
        private void btnQuery4_Click(object sender, EventArgs e)
        {
            string departmentCode = Interaction.InputBox(
                "Введите шифр кафедры:", "Запрос - Дисциплины кафедры");

            if (!string.IsNullOrWhiteSpace(departmentCode))
            {
                var departmentDisciplines = disciplines
                    .Where(d => d.DepartmentCode.Equals(departmentCode.Trim(), StringComparison.OrdinalIgnoreCase))
                    .Select(d => d.DisciplineName)
                    .ToList();

                if (departmentDisciplines.Any())
                {
                    string result = string.Join("\n", departmentDisciplines);
                    MessageBox.Show($"Дисциплины кафедры {departmentCode}:\n\n{result}",
                                  "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Для кафедры {departmentCode} дисциплины не найдены.",
                                  "Результат запроса", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



    }
}
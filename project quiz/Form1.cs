using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Net.Http.Headers;


namespace project_quiz
{
    public partial class Form1 : Form
    {
        private List<Question> questions = new List<Question> ();
        int cu_q_Index = 0;
        int corr_Answers = 0;
        int wrongAnswers = 0;
        int timeleft = 0;
        bool isAnswer = false;
        bool isclik;
        string selectq = "";
        private System.Timers.Timer timer;
        private bool timeExpiredMessageShown = false;
        public Form1()
        {
            InitializeComponent();
          

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            button1.Focus ();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            question1.CheckedChanged += RadioButton_CheckChanged;
            question2.CheckedChanged += RadioButton_CheckChanged;
             question3.CheckedChanged += RadioButton_CheckChanged;
            question4.CheckedChanged += RadioButton_CheckChanged;
            MBR(button2);
            MBR(button3);
            MBR(button4);
        }



        // method to load question

        public void load()
        {

            questions.Add(new Question("في اي عام تأسس نادي الهلال السعودي ", new string[] { "1957", "1960", "1975", "1980" }, 0));
            questions.Add(new Question("كم عدد بطولات دوري ابطال اسيا التي حققها الهلال حتى عام 2023؟", new string[] { "2", "4", "3", "5" }, 1));
            questions.Add(new Question("في اي عام تأسس نادي ريال مدريد ", new string[] { "1910", "1909", "1902", "1903" }, 2));
            questions.Add(new Question("من هو اللاعب الذي يحمل الرقم القياسي كافضل هداف في تاريخ ريال مدريد", new string[] { "كريم بنزيما", "راؤول غونزانيس", "كريستيانو رونالدو", "ألفريدو دي ستيفانو" }, 3));
            questions.Add(new Question("في اي عام فاز المنتخب الفرنسي بكاس العالم لاول مرة ", new string[] { "1990", "1999", "2018", "1998" }, 4));
            questions.Add(new Question("كم مره فاز المنتخب البرازيلي بكاس العالم  ", new string[] { "3", "4", "6", "5" }, 5));


        }
        private void load2()
        {
            questions.Add(new Question("ماهي اكبر دوله في العالم من حيث المساحة ", new string[] { "الولايات المتحدة الامريكية", "الصين", "روسيا", "كندا" }, 2));
            questions.Add(new Question("ماهي وحدة قياس الحرارة ", new string[] { "الامبير ", "الكيلوغرام", "النيوتن", "درجة مئوية" }, 3));
            questions.Add(new Question("في اي عام وقعت الثورة الفرنسية ", new string[] { "1899", "1848", "1776", "1789" }, 3));
            questions.Add(new Question("ماهو اطول نهر في العالم ", new string[] { "النيل", "الامازون", "المسيسيبي", "اليانغتسي" }, 1));
            questions.Add(new Question("من هو مولف رواية دون كيخوتة ", new string[] { "سيرافانتس", "شكسبير", "دانتة", "تولستوي" }, 0));



        }
        private void load3()
        {
            questions.Add(new Question("من هو اول نبي ارسلة الله للبشر", new string[] {"موسى عليه السلام ", " عيسى علية السلام", " آدم علية السلام", "نوح علية السلام" }, 2));
            questions.Add(new Question("ماهو اول مسجد بني في الاسلام؟", new string[] { "المسجد الاقصى", "المسجد النبوي", "المسجد الحرام", "مسجد قباء" }, 0));
            questions.Add(new Question("كم عدد السور في القران الكريم؟",new string[] {"100","110","104","105"},2));
            questions.Add(new Question("كم عدد الانبياء الذين ذكروا في القران الكريم؟", new string[] { "18", "20", "30", "25" }, 3));
            questions.Add(new Question("ماهي الغزوة التي وقعت بعد غزوة بدر الكبرى؟", new string[] { "غزوة احد", "غزوة مؤتة", "غزوة الخندق", "غزوة تبوك" }, 0));
            questions.Add(new Question("كم كان عدد جيش المسلمين في غزوة بدر؟", new string[] { "100", "315", "313", "1000" }, 2));
        }


        private void Display()
        {
            if (cu_q_Index < questions.Count)
            {
                Question question = questions[cu_q_Index];
                labelquestion.Text = question.Text;
                question1.Text = question.option[0];
                question2.Text = question.option[1];
                question3.Text = question.option[2];
                question4.Text = question.option[3];
                timeleft = 25; 
                labeltime.Text = $"{timeleft} : الوقت المتبقي"; 
                Clear();
                isAnswer = false;
                isclik = false;

               
            }
            else
            {
                Showresults();
                return;
            }
        }


        private void Checkanswer(RadioButton selected)
        {
            Question question = questions[cu_q_Index];
            int selectAnswer = -1;
            if (selected == question1)
                selectAnswer = 0;
            if (selected == question2)
                selectAnswer = 1;
            if (selected == question3)
                selectAnswer = 2;
            if (selected == question4)
                selectAnswer = 3;

            if (selectAnswer == question.Corr_option)
            {
                ++corr_Answers;
                MessageBox.Show("اجابة صحيحة");
            }
            else
            {
                wrongAnswers++;
                MessageBox.Show("اجابة خاطئة!");
            }

        }
        private void RadioButton_CheckChanged(object sender, EventArgs e)
        {
            if (isclik)
                return;
            if (isAnswer)
            {
                MessageBox.Show("لا يمكن تغيير الاجابة بعد اختيارها", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RadioButton selected = sender as RadioButton;
            if (selected != null && selected.Checked)
            {
                Checkanswer(selected);
                isAnswer = true;

            }
        }

        private void QuestionTimer_Elapsed(Object sender, ElapsedEventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft--;
                try
                {
                    Invoke(new Action(() => labeltime.Text = $"{timeleft} : الوقت المتبقي"));
                }
                catch (Exception ex) { }
            }
            else
            {
                timer.Stop();
                Invoke(new Action(() =>
                {
                    if (!isAnswer)
                    {
                        MessageBox.Show("انتهى الوقت");
                        Nextq(); 
                    }
                }));
            }
        }


        private void Nextq()
        {
            if (cu_q_Index >= questions.Count)
            {
                Showresults();
                return;
            }

            cu_q_Index++; 
            Display();

            timeleft = 25; 
            labeltime.Text = $"{timeleft} : الوقت المتبقي"; 
            timer.Start(); 

        }


        private void Clear()
        {
            question1.Checked = false;
            question2.Checked = false;
            question3.Checked = false;
            question4.Checked = false;

            question1.TabStop = false;
            question2.TabStop = false;
            question3.TabStop = false;
            question4.TabStop = false;

        }
        private void Showresults()
        {
            timer1.Stop();
            labelquestion.Text = "تم الانتهاء من الاسئلة";
            labeltime.Text = " :الاجابات الصحيحة" + corr_Answers.ToString() + "\n" +
                "الاجابات الخاطئة:" + wrongAnswers.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isclik = true;
            timer.Stop(); 
            Nextq(); 
        }

        private void btn_click()
        {
            timer?.Stop(); 
            labelquestion.Visible = true;
            labeltime.Visible = true;
            panel1.Visible = true;
            question1.Visible = true;
            question2.Visible = true;
            question3.Visible = true;
            question4.Visible = true;
            button1.Visible = true;
            Display();

            timer = new System.Timers.Timer(1000);
            timer.Elapsed += QuestionTimer_Elapsed;
            timer.Start();
        }

        private void MBR(Button button)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0,0,button.Width,button.Height);
            button.Region = new Region(path);
        }
        private void LoadNewQuiz(Action loadMethod)
        {
            questions.Clear(); 
            loadMethod(); 
            cu_q_Index = 0;
            corr_Answers = 0;
            wrongAnswers = 0;
            Clear(); 
            timeleft = 25; 
            labeltime.Text = "25 : الوقت المتبقي";
            timeExpiredMessageShown = false; 
            btn_click(); 
        }




        private void button3_Click(object sender, EventArgs e)
        {
            LoadNewQuiz(load2);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadNewQuiz(load);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadNewQuiz(load3);
        }
    }
}

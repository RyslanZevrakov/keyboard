using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace keyboard
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        bool caseSensitive = false;
        private int symbolsTyped = 0;
        private int totalSymbols = 0;
        private int minutesElapsed = 0;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMinutes(1);
            timer.Tick += Timer_Tick;

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            minutesElapsed++;
            double charsPerMinute = (double)symbolsTyped / minutesElapsed;
            speed.Text = charsPerMinute.ToString();
            totalSymbols += symbolsTyped;
            symbolsTyped = 0;
        }

        private void ButtonClick_Start(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = false;
            Stop.IsEnabled = true;
            TextBlock2.Focusable = true;
            TextBlock2.Focus();

            if (caseSensitive)
            {
                for (int k = 0; k < 4; k++)
                {
                    string s = "";
                    Random r = new Random();
                    for (int i = 0; i < sliderDifficulty.Value; i++)
                    {
                        s += (char)(r.Next(64, 122));
                    }

                    TextBlock1.Text += s;
                    TextBlock1.Text += " ";
                }

            }
            else
            {
                for (int k = 0; k < 4; k++)
                {
                    string s = "";
                    Random r = new Random();
                    for (int i = 0; i < sliderDifficulty.Value; i++)
                    {
                        s += (char)(r.Next(97, 122));
                    }

                    TextBlock1.Text += s;
                    TextBlock1.Text += " ";
                }
            }


            }

        private void ButtonClick_Stop(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = true;
            Stop.IsEnabled = false;
            TextBlock1.Text = "";
        }

        private void sliderDifficulty_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            difficult.Text = sliderDifficulty.Value.ToString();
        }


        private void TextBlock2_KeyDown(object sender, KeyEventArgs e)
        {
           // Fails.Text = symbolsTyped.ToString();
            

            if (e.Key == Key.Back)
            { if (TextBlock2.Text.Length != 0) {

                    symbolsTyped++;
                    TextBlock2.Text = TextBlock2.Text.Substring(0, TextBlock2.Text.Length - 1);
                    BorderBackspace.Background = new SolidColorBrush(Colors.Bisque);

                }

            }
            if (e.Key == Key.Enter)
            {
                BordeEnter.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
            {
                if (e.Key == Key.LeftCtrl)
                {
                    BorderleftCtrl.Background = new SolidColorBrush(Colors.Bisque);
                }
                else
                {
                    BorderrightCtrl.Background = new SolidColorBrush(Colors.Bisque);
                }
            }
            if (e.Key == Key.LWin || e.Key == Key.RWin)
            {
                if (e.Key == Key.LWin)
                {
                    BorderleftWin.Background = new SolidColorBrush(Colors.Bisque);
                }
                else
                {
                    BorderrightWin.Background = new SolidColorBrush(Colors.Bisque);
                }
            }
            if (e.Key == Key.System )
            {
                
                    BorderleftAlt.Background = new SolidColorBrush(Colors.Bisque);
               
                    
                
            }
            if (e.Key == Key.Q)
            {

                TextBlock2.Text += TextQ.Text.ToString();
                BorderQ.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.W)
            {
                TextBlock2.Text += TextW.Text.ToString();
                BorderW.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.E)
            {
                TextBlock2.Text += TextE.Text.ToString();
                BorderE.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.R)
            {
                TextBlock2.Text += TextR.Text.ToString();
                BorderR.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.T)
            {
                TextBlock2.Text += TextT.Text.ToString();
                BorderT.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.Y)
            {
                TextBlock2.Text += TextY.Text.ToString();
                BorderY.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.U)
            {
                TextBlock2.Text += TextU.Text.ToString();
                BorderU.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.I)
            {
                TextBlock2.Text += TextI.Text.ToString();
                BorderI.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.O)
            {
                TextBlock2.Text += TextO.Text.ToString();
                BorderO.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.P)
            {
                TextBlock2.Text += TextP.Text.ToString(); ;
                BorderP.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.A)
            {
                TextBlock2.Text += TextA.Text.ToString();
                BorderA.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.S)
            {
                TextBlock2.Text += TextS.Text.ToString();
                BorderS.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D)
            {
                TextBlock2.Text += TextD.Text.ToString();
                BorderD.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.F)
            {
                TextBlock2.Text += TextF.Text.ToString();
                BorderF.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.G)
            {
                TextBlock2.Text += TextG.Text.ToString();
                BorderG.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.H)
            {
                TextBlock2.Text += TextH.Text.ToString();
                BorderH.Background = new SolidColorBrush(Colors.Bisque);

            }
            if (e.Key == Key.J)
            {
                TextBlock2.Text += TextJ.Text.ToString();
                BorderJ.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.K)
            {
                TextBlock2.Text += TextK.Text.ToString();
                BorderK.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.L)
            {
                TextBlock2.Text += TextL.Text.ToString();
                BorderL.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.Z)
            {
                TextBlock2.Text += TextZ.Text.ToString();
                BorderZ.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.X)
            {
                TextBlock2.Text += TextX.Text.ToString();
                BorderX.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.C)
            {
                TextBlock2.Text += TextC.Text.ToString();
                BorderC.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.V)
            {
                TextBlock2.Text += TextV.Text.ToString();
                BorderV.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.B)
            {
                TextBlock2.Text += TextB.Text.ToString();
                BorderB.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.N)
            {
                TextBlock2.Text += TextN.Text.ToString();
                BorderN.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.M)
            {
                TextBlock2.Text += TextM.Text.ToString();
                BorderM.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.Capital)
            {

                if (TextE.Text.Equals("e"))
                {
                    TextQ.Text = "Q";
                    TextW.Text = "W";
                    TextE.Text = "E";
                    TextR.Text = "R";
                    TextT.Text = "T";
                    TextY.Text = "Y";
                    TextU.Text = "U";
                    TextI.Text = "I";
                    TextO.Text = "O";
                    TextP.Text = "P";
                    TextA.Text = "A";
                    TextS.Text = "S";
                    TextD.Text = "D";
                    TextF.Text = "F";
                    TextG.Text = "G";
                    TextH.Text = "H";
                    TextJ.Text = "J";
                    TextK.Text = "K";
                    TextL.Text = "L";
                    TextZ.Text = "Z";
                    TextX.Text = "X";
                    TextC.Text = "C";
                    TextV.Text = "V";
                    TextB.Text = "B";
                    TextN.Text = "N";
                    TextM.Text = "M";
                    BorderCapsLock.Background = new SolidColorBrush(Colors.Bisque);
                }
                else if (TextE.Text.Equals("E"))
                {

                    TextQ.Text = "q";
                    TextW.Text = "w";
                    TextE.Text = "e";
                    TextR.Text = "r";
                    TextT.Text = "t";
                    TextY.Text = "y";
                    TextU.Text = "u";
                    TextI.Text = "i";
                    TextO.Text = "o";
                    TextP.Text = "p";
                    TextA.Text = "a";
                    TextS.Text = "s";
                    TextD.Text = "d";
                    TextF.Text = "f";
                    TextG.Text = "g";
                    TextH.Text = "h";
                    TextJ.Text = "j";
                    TextK.Text = "k";
                    TextL.Text = "l";
                    TextZ.Text = "z";
                    TextX.Text = "x";
                    TextC.Text = "c";
                    TextV.Text = "v";
                    TextB.Text = "b";
                    TextN.Text = "n";
                    TextM.Text = "m";
                    BorderCapsLock.Background = new SolidColorBrush(Colors.Bisque);
                }

            }
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                TextQ.Text = "Q";
                TextW.Text = "W";
                TextE.Text = "E";
                TextR.Text = "R";
                TextT.Text = "T";
                TextY.Text = "Y";
                TextU.Text = "U";
                TextI.Text = "I";
                TextO.Text = "O";
                TextP.Text = "P";
                TextA.Text = "A";
                TextS.Text = "S";
                TextD.Text = "D";
                TextF.Text = "F";
                TextG.Text = "G";
                TextH.Text = "H";
                TextJ.Text = "J";
                TextK.Text = "K";
                TextL.Text = "L";
                TextZ.Text = "Z";
                TextX.Text = "X";
                TextC.Text = "C";
                TextV.Text = "V";
                TextB.Text = "B";
                TextN.Text = "N";
                TextM.Text = "M";
                D6.Text = "^";
                D2.Text = "@";
                minus.Text = "_";
                if (e.Key == Key.LeftShift)
                {
                    BordeleftShift.Background = new SolidColorBrush(Colors.Bisque);

                }
                else
                {
                    BorderrightShift.Background = new SolidColorBrush(Colors.Bisque);
                }
            }
            if (e.Key == Key.Oem3)
            {
                TextBlock2.Text += Oem3.Text.ToString();
                BorderOem3.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D1)
            {
                TextBlock2.Text += D1.Text.ToString();
                Border1.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D2)
            {
                TextBlock2.Text += D2.Text.ToString();
                Border2.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D3)
            {
                TextBlock2.Text += D3.Text.ToString();
                Border3.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D4)
            {
                TextBlock2.Text += D4.Text.ToString();
                Border4.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D5)
            {
                TextBlock2.Text += D5.Text.ToString();
                Border5.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D6)
            {
                TextBlock2.Text += D6.Text.ToString();
                Border6.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D7)
            {
                TextBlock2.Text += D7.Text.ToString();
                Border7.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D8)
            {
                TextBlock2.Text += D8.Text.ToString();
                Border8.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D9)
            {
                TextBlock2.Text += D9.Text.ToString();
                Border9.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.D0)
            {
                TextBlock2.Text += D0.Text.ToString();
                Border0.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.OemMinus)
            {
                TextBlock2.Text += minus.Text.ToString();
                Borderminus.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.OemPlus)
            {
                TextBlock2.Text += evenly.Text.ToString();
                Borderevenly.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.OemOpenBrackets)
            {
                TextBlock2.Text += leftSquareBracket.Text.ToString();
                BorderTextBlock_KeyUp_leftSquareBracket.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.Oem6)
            {
                TextBlock2.Text += rightSquareBracket.Text.ToString();
                BorderTextBlock_KeyUp_rightSquareBracket.Background = new SolidColorBrush(Colors.Bisque);

            }
            if (e.Key == Key.Oem5)
            {
                TextBlock2.Text += rightSlash.Text.ToString();
                BorderrightSlash.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.Oem1)
            {
                TextBlock2.Text += semicolon.Text.ToString();
                Bordersemicolon.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.OemQuotes)
            {
                TextBlock2.Text += dash.Text.ToString();
                Borderdash.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.OemComma)
            {
                TextBlock2.Text += comma.Text.ToString();
                Bordercomma.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.OemPeriod)
            {
                TextBlock2.Text += point.Text.ToString();
                Borderpoint.Background = new SolidColorBrush(Colors.Bisque);

            }
            if (e.Key == Key.OemQuestion)
            {
                TextBlock2.Text += leftSlash.Text.ToString();
                BorderleftSlash.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.Space)
            {
                TextBlock2.Text += " ";

                Borderspace.Background = new SolidColorBrush(Colors.Bisque);
            }
            if (e.Key == Key.Tab)
            {
                BorderTab.Background = new SolidColorBrush(Colors.Bisque);
                
            }
            char[] generatedTextChars= TextBlock1.Text.ToCharArray();
            char[] inputTextChars = TextBlock2.Text.ToCharArray();

            if (inputTextChars != null)
            {
                try
                {
                    TextBlock2.Foreground = Brushes.Black;

                    for (int i = 0; i < generatedTextChars.Length; i++)
                    {
                        if (i >= inputTextChars.Length || i >= TextBlock2.Text.Length)
                        {
                            break;
                        }

                        if (generatedTextChars[i] != inputTextChars[i])
                        {
                            TextBlock2.Foreground = Brushes.Red;
                            Fails.Text = (int.Parse(Fails.Text) + 1)+" ";
                            break;
                        }
                    }
                }
                catch (System.IndexOutOfRangeException)
                {

                }
            }
            symbolsTyped++;


        }
        private void TextBlock2_KeyUp(object sender, KeyEventArgs e)

        {
            if (e.Key == Key.Q)
            {

                BorderQ.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
            }
            if (e.Key == Key.W)
            {

                BorderW.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE6F077"));
            }
            if (e.Key == Key.E)
            {

                BorderE.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
            }
            if (e.Key == Key.R)
            {

                BorderR.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF77BEF0"));
            }
            if (e.Key == Key.T)
            {

                BorderT.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF77BEF0"));
            }
            if (e.Key == Key.Y)
            {
                BorderY.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDB77F0"));
            }
            if (e.Key == Key.U)
            {

                BorderU.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDB77F0"));
            }
            if (e.Key == Key.I)
            {

                BorderI.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
            }
            if (e.Key == Key.O)
            {

                BorderO.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE6F077"));
            }
            if (e.Key == Key.P)
            {

                BorderP.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
            }
            if (e.Key == Key.A)
            {

                BorderA.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
            }
            if (e.Key == Key.S)
            {

                BorderS.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE6F077"));
            }
            if (e.Key == Key.D)
            {

                BorderD.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
            }
            if (e.Key == Key.F)
            {

                BorderF.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF77BEF0"));
            }
            if (e.Key == Key.G)
            {

                BorderG.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF77BEF0"));
            }
            if (e.Key == Key.H)
            {

                BorderH.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDB77F0"));

            }
            if (e.Key == Key.J)
            {

                BorderJ.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDB77F0"));
            }
            if (e.Key == Key.K)
            {

                BorderK.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
            }
            if (e.Key == Key.L)
            {

                BorderL.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE6F077")); ;
            }
            if (e.Key == Key.Z)
            {

                BorderZ.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
            }
            if (e.Key == Key.X)
            {

                BorderX.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE6F077"));
            }
            if (e.Key == Key.C)
            {

                BorderC.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
            }
            if (e.Key == Key.V)
            {

                BorderV.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF77BEF0"));
            }
            if (e.Key == Key.B)
            {

                BorderB.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF77BEF0"));
            }
            if (e.Key == Key.N)
            {

                BorderN.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDB77F0"));
            }
            if (e.Key == Key.M)
            {

                BorderM.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDB77F0"));
            }
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {

                TextQ.Text = "q";
                TextW.Text = "w";
                TextE.Text = "e";
                TextR.Text = "r";
                TextT.Text = "t";
                TextY.Text = "y";
                TextU.Text = "u";
                TextI.Text = "i";
                TextO.Text = "o";
                TextP.Text = "p";
                TextA.Text = "a";
                TextS.Text = "s";
                TextD.Text = "d";
                TextF.Text = "f";
                TextG.Text = "g";
                TextH.Text = "h";
                TextJ.Text = "j";
                TextK.Text = "k";
                TextL.Text = "l";
                TextZ.Text = "z";
                TextX.Text = "x";
                TextC.Text = "c";
                TextV.Text = "v";
                TextB.Text = "b";
                TextN.Text = "n";
                TextM.Text = "m";
                D6.Text = "6";
                D2.Text = "2";
                minus.Text = "-";
                if (e.Key == Key.LeftShift)
                {
                    BordeleftShift.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));

                }
                else
                {
                    BorderrightShift.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }

            }
            if (e.Key == Key.Capital)
            {

                if (TextE.Text.Equals("e"))
                {

                    BorderCapsLock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }
                else if (TextE.Text.Equals("E"))
                {


                    BorderCapsLock.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }

            }
            if (e.Key == Key.LeftCtrl || e.Key == Key.RightCtrl)
            {
                if (e.Key == Key.LeftCtrl)
                {
                    BorderleftCtrl.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }
                else
                {
                    BorderrightCtrl.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }
            }
            if (e.Key == Key.LWin || e.Key == Key.RWin)
            {
                if (e.Key == Key.LWin)
                {
                    BorderleftWin.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }
                else
                {
                    BorderrightWin.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }
            }
            if (e.Key == Key.System )
            {
                
                    BorderleftAlt.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                
            }
            if (e.Key == Key.Enter)
                {
                    BordeEnter.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }
                if (e.Key == Key.Tab)
                {
                
                BorderTab.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }
                if (e.Key == Key.Back)
                {

                    BorderBackspace.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFB5B5B5"));
                }
                if (e.Key == Key.Oem3)
                {

                    BorderOem3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
                }
                if (e.Key == Key.D1)
                {

                    Border1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
                }
                if (e.Key == Key.D2)
                {

                    Border2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
                }
                if (e.Key == Key.D3)
                {

                    Border3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE6F077"));
                }
                if (e.Key == Key.D4)
                {

                    Border4.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.D5)
                {

                    Border5.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF77BEF0"));
                }
                if (e.Key == Key.D6)
                {

                    Border6.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF77BEF0"));
                }
                if (e.Key == Key.D7)
                {

                    Border7.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDB77F0"));
                }
                if (e.Key == Key.D8)
                {

                    Border8.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFDB77F0"));
                }
                if (e.Key == Key.D9)
                {

                    Border9.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF07795"));
                }
                if (e.Key == Key.D0)
                {

                    Border0.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE6F077"));
                }
                if (e.Key == Key.OemMinus)
                {

                    Borderminus.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.OemPlus)
                {

                    Borderevenly.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.OemOpenBrackets)
                {

                    BorderTextBlock_KeyUp_leftSquareBracket.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.Oem6)
                {

                    BorderTextBlock_KeyUp_rightSquareBracket.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));

                }
                if (e.Key == Key.Oem5)
                {

                    BorderrightSlash.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.Oem1)
                {

                    Bordersemicolon.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.OemQuotes)
                {

                    Borderdash.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.OemComma)
                {

                    Bordercomma.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.OemPeriod)
                {
                    Borderpoint.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));

                }
                if (e.Key == Key.OemQuestion)
                {

                    BorderleftSlash.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7FF077"));
                }
                if (e.Key == Key.Space)
                {

                    Borderspace.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("Orange"));
                }
            }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

            caseSensitive = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            caseSensitive = false;

        }
    }
    } 

    


using Angel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Angel
{
    public partial class MainWindow : Window
    {
        public static bool btnSetIsClicked = false;
        SolidColorBrush outputColor = new SolidColorBrush();
        SolidColorBrush originalColor = new SolidColorBrush();
        SolidColorBrush labelOutputColor = new SolidColorBrush();
        SolidColorBrush labelOriginalColor = new SolidColorBrush();
        Label[] keyLabels = new Label[93];
        Ellipse[] key = new Ellipse[93];
        private readonly Dictionary<Key, Label> labelMappings;
        private bool shiftKeyPressed = false;
        private bool capsLockEnabled = false;
        private bool isEventHandlersEnabled = false;
        //string defaultMessage = "Your Message will appear here"; // Default message text
        //string eMessage = "Encrypted Message will appear here"; // Default message text

        public MainWindow()
        {
            InitializeComponent();
            isEventHandlersEnabled = false; // Initially disable event handlers

            key[0] = eclipse1;
            key[1] = eclipse2;
            key[2] = eclipse3;
            key[3] = eclipse4;
            key[4] = eclipse5;
            key[5] = eclipse6;
            key[6] = eclipse7;
            key[7] = eclipse8;
            key[8] = eclipse9;
            key[9] = eclipse10;
            key[10] = eclipse11;
            key[11] = eclipse12;
            key[12] = eclipse13;
            key[13] = eclipse14;
            key[14] = eclipse15;
            key[15] = eclipse16;
            key[16] = eclipse17;
            key[17] = eclipse18;
            key[18] = eclipse19;
            key[19] = eclipse20;
            key[20] = eclipse21;
            key[21] = eclipse22;
            key[22] = eclipse23;
            key[23] = eclipse24;
            key[24] = eclipse25;
            key[25] = eclipse26;
            key[26] = eclipse27;
            key[27] = eclipse28;
            key[28] = eclipse29;
            key[29] = eclipse30;
            key[30] = eclipse31;
            key[31] = eclipse32;
            key[32] = eclipse33;
            key[33] = eclipse34;
            key[34] = eclipse35;
            key[35] = eclipse36;
            key[36] = eclipse37;
            key[37] = eclipse38;
            key[38] = eclipse39;
            key[39] = eclipse40;
            key[40] = eclipse41;
            key[41] = eclipse42;
            key[42] = eclipse43;
            key[43] = eclipse44;
            key[44] = eclipse45;
            key[45] = eclipse46;
            key[46] = eclipse47;
            key[47] = eclipse48;
            key[48] = eclipse49;
            key[49] = eclipse50;
            key[50] = eclipse51;
            key[51] = eclipse52;
            key[52] = eclipse53;
            key[53] = eclipse54;
            key[54] = eclipse55;
            key[55] = eclipse56;
            key[56] = eclipse57;
            key[57] = eclipse58;
            key[58] = eclipse59;
            key[59] = eclipse60;
            key[60] = eclipse61;
            key[61] = eclipse62;
            key[62] = eclipse63;
            key[63] = eclipse64;
            key[64] = eclipse65;
            key[65] = eclipse66;
            key[66] = eclipse67;
            key[67] = eclipse68;
            key[68] = eclipse69;
            key[69] = eclipse70;
            key[70] = eclipse71;
            key[71] = eclipse72;
            key[72] = eclipse73;
            key[73] = eclipse74;
            key[74] = eclipse75;
            key[75] = eclipse76;
            key[76] = eclipse77;
            key[77] = eclipse78;
            key[78] = eclipse79;
            key[79] = eclipse80;
            key[80] = eclipse81;
            key[81] = eclipse82;
            key[82] = eclipse83;
            key[83] = eclipse84;
            key[84] = eclipse85;
            key[85] = eclipse86;
            key[86] = eclipse87;
            key[87] = eclipse88;
            key[88] = eclipse89;
            key[89] = eclipse90;
            key[90] = eclipse91;
            key[91] = eclipse92;
            key[92] = eclipse93;


            keyLabels[0] = lbl1;
            keyLabels[1] = lbl2;
            keyLabels[2] = lbl3;
            keyLabels[3] = lbl4;
            keyLabels[4] = lbl5;
            keyLabels[5] = lbl6;
            keyLabels[6] = lbl7;
            keyLabels[7] = lbl8;
            keyLabels[8] = lbl9;
            keyLabels[9] = lbl10;
            keyLabels[10] = lbl11;
            keyLabels[11] = lbl12;
            keyLabels[12] = lbl13;
            keyLabels[13] = lbl14;
            keyLabels[14] = lbl15;
            keyLabels[15] = lbl16;
            keyLabels[16] = lbl17;
            keyLabels[17] = lbl18;
            keyLabels[18] = lbl19;
            keyLabels[19] = lbl20;
            keyLabels[20] = lbl21;
            keyLabels[21] = lbl22;
            keyLabels[22] = lbl23;
            keyLabels[23] = lbl24;
            keyLabels[24] = lbl25;
            keyLabels[25] = lbl26;
            keyLabels[26] = lbl27;
            keyLabels[27] = lbl28;
            keyLabels[28] = lbl29;
            keyLabels[29] = lbl30;
            keyLabels[30] = lbl31;
            keyLabels[31] = lbl32;
            keyLabels[32] = lbl33;
            keyLabels[33] = lbl34;
            keyLabels[34] = lbl35;
            keyLabels[35] = lbl36;
            keyLabels[36] = lbl37;
            keyLabels[37] = lbl38;
            keyLabels[38] = lbl39;
            keyLabels[39] = lbl40;
            keyLabels[40] = lbl41;
            keyLabels[41] = lbl42;
            keyLabels[42] = lbl43;
            keyLabels[43] = lbl44;
            keyLabels[44] = lbl45;
            keyLabels[45] = lbl46;
            keyLabels[46] = lbl47;
            keyLabels[47] = lbl48;
            keyLabels[48] = lbl49;
            keyLabels[49] = lbl50;
            keyLabels[50] = lbl51;
            keyLabels[51] = lbl52;
            keyLabels[52] = lbl53;
            keyLabels[53] = lbl54;
            keyLabels[54] = lbl55;
            keyLabels[55] = lbl56;
            keyLabels[56] = lbl57;
            keyLabels[57] = lbl58;
            keyLabels[58] = lbl59;
            keyLabels[59] = lbl60;
            keyLabels[60] = lbl61;
            keyLabels[61] = lbl62;
            keyLabels[62] = lbl63;
            keyLabels[63] = lbl64;
            keyLabels[64] = lbl65;
            keyLabels[65] = lbl66;
            keyLabels[66] = lbl67;
            keyLabels[67] = lbl68;
            keyLabels[68] = lbl69;
            keyLabels[69] = lbl70;
            keyLabels[70] = lbl71;
            keyLabels[71] = lbl72;
            keyLabels[72] = lbl73;
            keyLabels[73] = lbl74;
            keyLabels[74] = lbl75;
            keyLabels[75] = lbl76;
            keyLabels[76] = lbl77;
            keyLabels[77] = lbl78;
            keyLabels[78] = lbl79;
            keyLabels[79] = lbl80;
            keyLabels[80] = lbl81;
            keyLabels[81] = lbl82;
            keyLabels[82] = lbl83;
            keyLabels[83] = lbl84;
            keyLabels[84] = lbl85;
            keyLabels[85] = lbl86;
            keyLabels[86] = lbl87;
            keyLabels[87] = lbl88;
            keyLabels[88] = lbl89;
            keyLabels[89] = lbl90;
            keyLabels[90] = lbl91;
            keyLabels[91] = lbl92;
            keyLabels[92] = lbl93;
            //if (initialState)
            //    tbxInput.Text = defaultMessage; // If it's the initial state, display the default message
            //    tbxOutput.Text = eMessage;

            outputColor.Color = Color.FromRgb(181, 203, 153); //Color when clicked
            originalColor.Color = Color.FromRgb(211, 211, 211); //BGcolor of the eclipse
            labelOutputColor.Color = Color.FromRgb(0, 0, 0); //Color of the label
            labelOriginalColor.Color = Color.FromRgb(255, 255, 255); //ewan ko

            labelMappings = new Dictionary<Key, Label>
            {
                //`12345
                { Key.D1, lbl_1 },{ Key.D2, lbl_2 },{ Key.D3, lbl_3 },{ Key.D4, lbl_4 },{ Key.D5, lbl_5 },
                { Key.D6, lbl_6 },{ Key.D7, lbl_7 },{ Key.D8, lbl_8 },{ Key.D9, lbl_9 },{ Key.D0, lbl_0 },
                { Key.OemMinus, lbl_minus },{ Key.OemPlus, lbl_equal },

                //qwerty
                { Key.Q, lbl_q },
                { Key.W, lbl_w },
                { Key.R, lbl_r },
                { Key.E, lbl_e },
                { Key.T, lbl_t },
                { Key.Y, lbl_y },
                { Key.U, lbl_u },
                { Key.I, lbl_i },
                { Key.O, lbl_o },
                { Key.P, lbl_p },
                { Key.OemOpenBrackets, bracketL },
                { Key.OemCloseBrackets, bracketR },
                { Key.OemPipe, slashL },

                //asdfg
                { Key.A, lbl_a },
                { Key.S, lbl_s },
                { Key.D, lbl_d },
                { Key.F, lbl_f },
                { Key.G, lbl_g },
                { Key.H, lbl_h },
                { Key.J, lbl_j },
                { Key.K, lbl_k },
                { Key.L, lbl_l },
                { Key.OemSemicolon, lbl_semicolon },
                { Key.OemQuotes, lbl_qout },

                //zxcvb
                { Key.Z, lbl_z },
                { Key.X, lbl_x },
                { Key.C, lbl_c },
                { Key.V, lbl_v },
                { Key.B, lbl_b },
                { Key.N, lbl_n },
                { Key.M, lbl_m },
                { Key.OemComma, lbl_coma },
                { Key.OemPeriod, lbl_dot },
                { Key.OemQuestion, slashR },

                //Special Char
                { Key.Space, lbl_spacebar },
                { Key.LeftShift, lbl_shift },
                { Key.RightShift, lbl_shift },
                { Key.CapsLock, lbl_SLock },
                { Key.Enter, lbl_return },
                { Key.Tab, lbl_tab },
                { Key.Back, lbl_Back }
            };


        }

        private void EnableEventHandlers()
        {
            isEventHandlersEnabled = true;
        }

        private void DisableEventHandlers()
        {
            isEventHandlersEnabled = false;
        }

        void updateDisplayCount()
        {
            lblSelectionSecondsCounter1.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSelection[0]);
            lblSelectionMinutesCounter1.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSelection[1]);
            lblSelectionHoursCounter1.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSelection[2]);

            lblSelectionSecondsCounter2.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSettings[0]);
            lblSelectionMinutesCounter2.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSettings[1]);
            lblSelectionHoursCounter2.Content = EnigmaClass.countDisplayFormatter(EnigmaClass.ringSettings[2]);
        }

        void ringSelectorChecker()
        {
            if (EnigmaClass.ringSelection[0] == EnigmaClass.ringSelection[1] || EnigmaClass.ringSelection[1] == EnigmaClass.ringSelection[2] || EnigmaClass.ringSelection[0] == EnigmaClass.ringSelection[2])
            {
                btnPlusSeconds2.IsEnabled = false;
                btnPlusMinutes2.IsEnabled = false;
                btnPlusHours2.IsEnabled = false;
                btnMinusSeconds2.IsEnabled = false;
                btnMinusMinutes2.IsEnabled = false;
                btnMinusHours2.IsEnabled = false;
                btnSet.IsEnabled = false;
            }
            else
            {
                btnPlusSeconds2.IsEnabled = true;
                btnPlusMinutes2.IsEnabled = true;
                btnPlusHours2.IsEnabled = true;
                btnMinusSeconds2.IsEnabled = true;
                btnMinusMinutes2.IsEnabled = true;
                btnMinusHours2.IsEnabled = true;
                btnSet.IsEnabled = true;
            }
        }



        void keyLightUp()
        {
            for (int x = 0; x < keyLabels.Length; x++)
            {
                string label = (string)keyLabels[x].Content;
                // Example: if Content is a List<char>
                string content = tbxOutput.Content.ToString();
                string outputLastElement = content[content.Length - 1].ToString();
                if (outputLastElement == label)
                {
                    key[x].Fill = outputColor;
                    keyLabels[x].Foreground = labelOutputColor;
                }
                else if (outputLastElement == " ")
                {
                    for (int y = 0; y < keyLabels.Length; y++)
                    {
                        if (y == 93)
                        {
                            key[93].Fill = outputColor;
                            keyLabels[93].Foreground = labelOutputColor;
                        }
                        else
                        {
                            key[x].Fill = originalColor;
                            keyLabels[x].Foreground = labelOriginalColor;
                        }
                    }
                }
                else if (outputLastElement != label)
                {
                    key[x].Fill = originalColor;
                    keyLabels[x].Foreground = labelOriginalColor;
                }
            }
        }


        private void File_Click(object sender, RoutedEventArgs e)
        {
            bool fileReadSuccessfully = false;

            do
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Comma Separated Values (*.csv;)|*.csv;";
                if (ofd.ShowDialog() == true)
                {
                    FilePathTextBlock.Text = ofd.FileName;

                    if (FilePathTextBlock.Text.Length > 0)
                    {
                        EnigmaClass.ringLines.Clear();
                        Array.Clear(EnigmaClass.groupedRings, 0, EnigmaClass.groupedRings.Length);
                        EnigmaClass.ringSelection = new int[3] { 0, 0, 0 };
                        EnigmaClass.ringSettings = new int[3] { 0, 0, 0 };

                        fileReadSuccessfully = EnigmaClass.ReadFiles(FilePathTextBlock.Text);

                        if (fileReadSuccessfully)
                        {
                            updateDisplayCount();
                            EnigmaClass.ringContentSeparator();
                            ringC.Text = "Ring Count : " + EnigmaClass.ringCount();
                            rCount.Text = "Character Count per Ring : " + EnigmaClass.ringContentCount();
                            MessageBox.Show("Rings File has been Read and Formatted successfully! Please Proceed with the setup.\nFeel free to select another csv file that contains rings if you want.", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);

                            ToggleControls(true);
                        }
                        else
                        {
                            MessageBox.Show("Please select a valid CSV file.", "Invalid File", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                }
                else
                {
                    // User cancelled the file dialog
                    return;
                }
            }
            while (!fileReadSuccessfully);
        }


        private void ToggleControls(bool isEnabled)
        {
            btnPlusSeconds1.IsEnabled = isEnabled;
            btnPlusMinutes1.IsEnabled = isEnabled;
            btnPlusHours1.IsEnabled = isEnabled;
            btnMinusSeconds1.IsEnabled = isEnabled;
            btnMinusMinutes1.IsEnabled = isEnabled;
            btnMinusHours1.IsEnabled = isEnabled;
            File.IsEnabled = isEnabled;
            cbxReflector.IsEnabled = isEnabled;
            btnReset.IsEnabled = isEnabled;
        }

      

        private void btnPlusSeconds1_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSelectionCounter(0, '+');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnPlusMinutes1_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSelectionCounter(1, '+');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnPlusHours1_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSelectionCounter(2, '+');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnMinusSeconds1_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSelectionCounter(0, '-');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnMinusMinutes1_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSelectionCounter(1, '-');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnMinusHours1_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSelectionCounter(2, '-');
            updateDisplayCount();
            ringSelectorChecker();
        }

        private void btnPlusSeconds2_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSettingsCounter(0, '+');
            updateDisplayCount();
        }

        private void btnPlusMinutes2_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSettingsCounter(1, '+');
            updateDisplayCount();
        }

        private void btnPlusHours2_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSettingsCounter(2, '+');
            updateDisplayCount();
        }

        private void btnMinusSeconds2_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSettingsCounter(0, '-');
            updateDisplayCount();
        }

        private void btnMinusMinutes2_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSettingsCounter(1, '-');
            updateDisplayCount();
        }

        private void btnMinusHours2_Click(object sender, RoutedEventArgs e)
        {
            EnigmaClass.ringSettingsCounter(2, '-');
            updateDisplayCount();
        }

        private void cbxReflector_Checked(object sender, RoutedEventArgs e)
        {
            EnigmaClass.checkboxIsChecked = true;
        }

        private void cbxReflector_Unchecked(object sender, RoutedEventArgs e)
        {
            EnigmaClass.checkboxIsChecked = false;
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            btnSetIsClicked = true;
            if (MessageBox.Show("Are you sure you want to LOCK THE SELECTION?", "Enigma", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                MessageBox.Show("Enigma will hide the setup.\nPlease TAKE NOTE of the setup of your Enigma Machine", "Enigma", MessageBoxButton.OK, MessageBoxImage.Warning);
                EnigmaClass.offsetRotors();
                MessageBox.Show("Enigma is now activated!", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);

                btnPlusSeconds1.IsEnabled = false;
                btnPlusMinutes1.IsEnabled = false;
                btnPlusHours1.IsEnabled = false;
                btnMinusSeconds1.IsEnabled = false;
                btnMinusMinutes1.IsEnabled = false;
                btnMinusHours1.IsEnabled = false;
                btnPlusSeconds2.IsEnabled = false;
                btnPlusMinutes2.IsEnabled = false;
                btnPlusHours2.IsEnabled = false;
                btnMinusSeconds2.IsEnabled = false;
                btnMinusMinutes2.IsEnabled = false;
                btnMinusHours2.IsEnabled = false;
                btnSet.IsEnabled = false;
                File.IsEnabled = false;
                cbxReflector.IsEnabled = false;
                tbxInput.Focus();
                EnableEventHandlers();
            }
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e)
        {


            if (btnSetIsClicked)
            {
                //bool isCapsLockOn = Console.CapsLock;
                if (e.KeyboardDevice.Modifiers == ModifierKeys.Shift || capsLockEnabled)
                {
                    switch (e.Key)
                    {
                        case Key.A:
                            tbxInput.Text += 'A';
                            tbxOutput.Content += EnigmaClass.encrypted('A');
                            keyLightUp();
                            break;
                        case Key.B:
                            tbxInput.Text += 'B';
                            tbxOutput.Content += EnigmaClass.encrypted('B');
                            keyLightUp();
                            break;
                        case Key.C:
                            tbxInput.Text += 'C';
                            tbxOutput.Content += EnigmaClass.encrypted('C');
                            keyLightUp();
                            break;
                        case Key.D:
                            tbxInput.Text += 'D';
                            tbxOutput.Content += EnigmaClass.encrypted('D');
                            keyLightUp();
                            break;
                        case Key.E:
                            tbxInput.Text += 'E';
                            tbxOutput.Content += EnigmaClass.encrypted('E');
                            keyLightUp();
                            break;
                        case Key.F:
                            tbxInput.Text += 'F';
                            tbxOutput.Content += EnigmaClass.encrypted('F');
                            keyLightUp();
                            break;
                        case Key.G:
                            tbxInput.Text += 'G';
                            tbxOutput.Content += EnigmaClass.encrypted('G');
                            keyLightUp();
                            break;
                        case Key.H:
                            tbxInput.Text += 'H';
                            tbxOutput.Content += EnigmaClass.encrypted('H');
                            keyLightUp();
                            break;
                        case Key.I:
                            tbxInput.Text += 'I';
                            tbxOutput.Content += EnigmaClass.encrypted('I');
                            keyLightUp();
                            break;
                        case Key.J:
                            tbxInput.Text += 'J';
                            tbxOutput.Content += EnigmaClass.encrypted('J');
                            keyLightUp();
                            break;
                        case Key.K:
                            tbxInput.Text += 'K';
                            tbxOutput.Content += EnigmaClass.encrypted('K');
                            keyLightUp();
                            break;
                        case Key.L:
                            tbxInput.Text += 'L';
                            tbxOutput.Content += EnigmaClass.encrypted('L');
                            keyLightUp();
                            break;
                        case Key.M:
                            tbxInput.Text += 'M';
                            tbxOutput.Content += EnigmaClass.encrypted('M');
                            keyLightUp();
                            break;
                        case Key.N:
                            tbxInput.Text += 'N';
                            tbxOutput.Content += EnigmaClass.encrypted('N');
                            keyLightUp();
                            break;
                        case Key.O:
                            tbxInput.Text += 'O';
                            tbxOutput.Content += EnigmaClass.encrypted('O');
                            keyLightUp();
                            break;
                        case Key.P:
                            tbxInput.Text += 'P';
                            tbxOutput.Content += EnigmaClass.encrypted('P');
                            keyLightUp();
                            break;
                        case Key.Q:
                            tbxInput.Text += 'Q';
                            tbxOutput.Content += EnigmaClass.encrypted('Q');
                            keyLightUp();
                            break;
                        case Key.R:
                            tbxInput.Text += 'R';
                            tbxOutput.Content += EnigmaClass.encrypted('R');
                            keyLightUp();
                            break;
                        case Key.S:
                            tbxInput.Text += 'S';
                            tbxOutput.Content += EnigmaClass.encrypted('S');
                            keyLightUp();
                            break;
                        case Key.T:
                            tbxInput.Text += 'T';
                            tbxOutput.Content += EnigmaClass.encrypted('T');
                            keyLightUp();
                            break;
                        case Key.U:
                            tbxInput.Text += 'U';
                            tbxOutput.Content += EnigmaClass.encrypted('U');
                            keyLightUp();
                            break;
                        case Key.V:
                            tbxInput.Text += 'V';
                            tbxOutput.Content += EnigmaClass.encrypted('V');
                            keyLightUp();
                            break;
                        case Key.W:
                            tbxInput.Text += 'W';
                            tbxOutput.Content += EnigmaClass.encrypted('W');
                            keyLightUp();
                            break;
                        case Key.X:
                            tbxInput.Text += 'X';
                            tbxOutput.Content += EnigmaClass.encrypted('X');
                            keyLightUp();
                            break;
                        case Key.Y:
                            tbxInput.Text += 'Y';
                            tbxOutput.Content += EnigmaClass.encrypted('Y');
                            keyLightUp();
                            break;
                        case Key.Z:
                            tbxInput.Text += 'Z';
                            tbxOutput.Content += EnigmaClass.encrypted('Z');
                            keyLightUp();
                            break;
                        case Key.D0:
                            tbxInput.Text += ')';
                            tbxOutput.Content += EnigmaClass.encrypted(')');
                            keyLightUp();
                            break;
                        case Key.D1:
                            tbxInput.Text += '!';
                            tbxOutput.Content += EnigmaClass.encrypted('!');
                            keyLightUp();
                            break;
                        case Key.D2:
                            tbxInput.Text += '@';
                            tbxOutput.Content += EnigmaClass.encrypted('@');
                            keyLightUp();
                            break;
                        case Key.D3:
                            tbxInput.Text += '#';
                            tbxOutput.Content += EnigmaClass.encrypted('#');
                            keyLightUp();
                            break;
                        case Key.D4:
                            tbxInput.Text += '$';
                            tbxOutput.Content += EnigmaClass.encrypted('$');
                            keyLightUp();
                            break;
                        case Key.D5:
                            tbxInput.Text += '%';
                            tbxOutput.Content += EnigmaClass.encrypted('%');
                            keyLightUp();
                            break;
                        case Key.D6:
                            tbxInput.Text += '^';
                            tbxOutput.Content += EnigmaClass.encrypted('^');
                            keyLightUp();
                            break;
                        case Key.D7:
                            tbxInput.Text += '&';
                            tbxOutput.Content += EnigmaClass.encrypted('&');
                            keyLightUp();
                            break;
                        case Key.D8:
                            tbxInput.Text += '*';
                            tbxOutput.Content += EnigmaClass.encrypted('*');
                            keyLightUp();
                            break;
                        case Key.D9:
                            tbxInput.Text += '(';
                            tbxOutput.Content += EnigmaClass.encrypted('(');
                            keyLightUp();
                            break;
                        case Key.Oem1:
                            tbxInput.Text += ':';
                            tbxOutput.Content += EnigmaClass.encrypted(':');
                            keyLightUp();
                            break;
                        case Key.Oem2:
                            tbxInput.Text += '?';
                            tbxOutput.Content += EnigmaClass.encrypted('?');
                            keyLightUp();
                            break;
                        case Key.Oem4:
                            tbxInput.Text += '{';
                            tbxOutput.Content += EnigmaClass.encrypted('{');
                            keyLightUp();
                            break;
                        case Key.Oem5:
                            tbxInput.Text += '|';
                            tbxOutput.Content += EnigmaClass.encrypted('|');
                            keyLightUp();
                            break;
                        case Key.Oem6:
                            tbxInput.Text += '}';
                            tbxOutput.Content += EnigmaClass.encrypted('}');
                            keyLightUp();
                            break;
                        case Key.OemComma:
                            tbxInput.Text += '<';
                            tbxOutput.Content += EnigmaClass.encrypted('<');
                            keyLightUp();
                            break;
                        case Key.OemPeriod:
                            tbxInput.Text += '>';
                            tbxOutput.Content += EnigmaClass.encrypted('>');
                            keyLightUp();
                            break;
                        case Key.OemMinus:
                            tbxInput.Text += '_';
                            tbxOutput.Content += EnigmaClass.encrypted('_');
                            keyLightUp();
                            break;
                        case Key.OemPlus:
                            tbxInput.Text += '+';
                            tbxOutput.Content += EnigmaClass.encrypted('+');
                            keyLightUp();
                            break;
                        case Key.OemQuotes:
                            tbxInput.Text += '"';
                            tbxOutput.Content += EnigmaClass.encrypted('"');
                            keyLightUp();
                            break;
                        case Key.Space:
                            tbxInput.Text += ' ';
                            tbxOutput.Content += EnigmaClass.encrypted(' ');
                            keyLightUp();
                            break;
                    }
                    //updateDisplayCount();
                }
                else
                {
                    switch (e.Key)
                    {
                        case Key.A:
                            tbxInput.Text += 'a';
                            tbxOutput.Content += EnigmaClass.encrypted('a');
                            keyLightUp();
                            break;
                        case Key.B:
                            tbxInput.Text += 'b';
                            tbxOutput.Content += EnigmaClass.encrypted('b');
                            keyLightUp();
                            break;
                        case Key.C:
                            tbxInput.Text += 'c';
                            tbxOutput.Content += EnigmaClass.encrypted('c');
                            keyLightUp();
                            break;
                        case Key.D:
                            tbxInput.Text += 'd';
                            tbxOutput.Content += EnigmaClass.encrypted('d');
                            keyLightUp();
                            break;
                        case Key.E:
                            tbxInput.Text += 'e';
                            tbxOutput.Content += EnigmaClass.encrypted('e');
                            keyLightUp();
                            break;
                        case Key.F:
                            tbxInput.Text += 'f';
                            tbxOutput.Content += EnigmaClass.encrypted('f');
                            keyLightUp();
                            break;
                        case Key.G:
                            tbxInput.Text += 'g';
                            tbxOutput.Content += EnigmaClass.encrypted('g');
                            keyLightUp();
                            break;
                        case Key.H:
                            tbxInput.Text += 'h';
                            tbxOutput.Content += EnigmaClass.encrypted('h');
                            keyLightUp();
                            break;
                        case Key.I:
                            tbxInput.Text += 'i';
                            tbxOutput.Content += EnigmaClass.encrypted('i');
                            keyLightUp();
                            break;
                        case Key.J:
                            tbxInput.Text += 'j';
                            tbxOutput.Content += EnigmaClass.encrypted('j');
                            keyLightUp();
                            break;
                        case Key.K:
                            tbxInput.Text += 'k';
                            tbxOutput.Content += EnigmaClass.encrypted('k');
                            keyLightUp();
                            break;
                        case Key.L:
                            tbxInput.Text += 'l';
                            tbxOutput.Content += EnigmaClass.encrypted('l');
                            keyLightUp();
                            break;
                        case Key.M:
                            tbxInput.Text += 'm';
                            tbxOutput.Content += EnigmaClass.encrypted('m');
                            keyLightUp();
                            break;
                        case Key.N:
                            tbxInput.Text += 'n';
                            tbxOutput.Content += EnigmaClass.encrypted('n');
                            keyLightUp();
                            break;
                        case Key.O:
                            tbxInput.Text += 'o';
                            tbxOutput.Content += EnigmaClass.encrypted('o');
                            keyLightUp();
                            break;
                        case Key.P:
                            tbxInput.Text += 'p';
                            tbxOutput.Content += EnigmaClass.encrypted('p');
                            keyLightUp();
                            break;
                        case Key.Q:
                            tbxInput.Text += 'q';
                            tbxOutput.Content += EnigmaClass.encrypted('q');
                            keyLightUp();
                            break;
                        case Key.R:
                            tbxInput.Text += 'r';
                            tbxOutput.Content += EnigmaClass.encrypted('r');
                            keyLightUp();
                            break;
                        case Key.S:
                            tbxInput.Text += 's';
                            tbxOutput.Content += EnigmaClass.encrypted('s');
                            keyLightUp();
                            break;
                        case Key.T:
                            tbxInput.Text += 't';
                            tbxOutput.Content += EnigmaClass.encrypted('t');
                            keyLightUp();
                            break;
                        case Key.U:
                            tbxInput.Text += 'u';
                            tbxOutput.Content += EnigmaClass.encrypted('u');
                            keyLightUp();
                            break;
                        case Key.V:
                            tbxInput.Text += 'v';
                            tbxOutput.Content += EnigmaClass.encrypted('v');
                            keyLightUp();
                            break;
                        case Key.W:
                            tbxInput.Text += 'w';
                            tbxOutput.Content += EnigmaClass.encrypted('w');
                            keyLightUp();
                            break;
                        case Key.X:
                            tbxInput.Text += 'x';
                            tbxOutput.Content += EnigmaClass.encrypted('x');
                            keyLightUp();
                            break;
                        case Key.Y:
                            tbxInput.Text += 'y';
                            tbxOutput.Content += EnigmaClass.encrypted('y');
                            keyLightUp();
                            break;
                        case Key.Z:
                            tbxInput.Text += 'z';
                            tbxOutput.Content += EnigmaClass.encrypted('z');
                            keyLightUp();
                            break;
                        case Key.NumPad0:
                        case Key.D0:
                            tbxInput.Text += '0';
                            tbxOutput.Content += EnigmaClass.encrypted('0');
                            keyLightUp();
                            break;
                        case Key.NumPad1:
                        case Key.D1:
                            tbxInput.Text += '1';
                            tbxOutput.Content += EnigmaClass.encrypted('1');
                            keyLightUp();
                            break;
                        case Key.NumPad2:
                        case Key.D2:
                            tbxInput.Text += '2';
                            tbxOutput.Content += EnigmaClass.encrypted('2');
                            keyLightUp();
                            break;
                        case Key.NumPad3:
                        case Key.D3:
                            tbxInput.Text += '3';
                            tbxOutput.Content += EnigmaClass.encrypted('3');
                            keyLightUp();
                            break;
                        case Key.NumPad4:
                        case Key.D4:
                            tbxInput.Text += '4';
                            tbxOutput.Content += EnigmaClass.encrypted('4');
                            keyLightUp();
                            break;
                        case Key.NumPad5:
                        case Key.D5:
                            tbxInput.Text += '5';
                            tbxOutput.Content += EnigmaClass.encrypted('5');
                            keyLightUp();
                            break;
                        case Key.NumPad6:
                        case Key.D6:
                            tbxInput.Text += '6';
                            tbxOutput.Content += EnigmaClass.encrypted('6');
                            keyLightUp();
                            break;
                        case Key.NumPad7:
                        case Key.D7:
                            tbxInput.Text += '7';
                            tbxOutput.Content += EnigmaClass.encrypted('7');
                            keyLightUp();
                            break;
                        case Key.NumPad8:
                        case Key.D8:
                            tbxInput.Text += '8';
                            tbxOutput.Content += EnigmaClass.encrypted('8');
                            keyLightUp();
                            break;
                        case Key.NumPad9:
                        case Key.D9:
                            tbxInput.Text += '9';
                            tbxOutput.Content += EnigmaClass.encrypted('9');
                            keyLightUp();
                            break;
                        case Key.Oem1:
                            tbxInput.Text += ';';
                            tbxOutput.Content += EnigmaClass.encrypted(';');
                            keyLightUp();
                            break;
                        case Key.Divide:
                        case Key.Oem2:
                            tbxInput.Text += '/';
                            tbxOutput.Content += EnigmaClass.encrypted('/');
                            keyLightUp();
                            break;
                        case Key.Oem4:
                            tbxInput.Text += '[';
                            tbxOutput.Content += EnigmaClass.encrypted('[');
                            keyLightUp();
                            break;
                        case Key.Oem5:
                            tbxInput.Text += '\\';
                            tbxOutput.Content += EnigmaClass.encrypted('\\');
                            keyLightUp();
                            break;
                        case Key.Oem6:
                            tbxInput.Text += ']';
                            tbxOutput.Content += EnigmaClass.encrypted(']');
                            keyLightUp();
                            break;
                        case Key.OemComma:
                            tbxInput.Text += ',';
                            tbxOutput.Content += EnigmaClass.encrypted(',');
                            keyLightUp();
                            break;
                        case Key.OemPeriod:
                        case Key.Decimal:
                            tbxInput.Text += '.';
                            tbxOutput.Content += EnigmaClass.encrypted('.');
                            keyLightUp();
                            break;
                        case Key.Subtract:
                        case Key.OemMinus:
                            tbxInput.Text += '-';
                            tbxOutput.Content += EnigmaClass.encrypted('-');
                            keyLightUp();
                            break;
                        case Key.OemPlus:
                            tbxInput.Text += '=';
                            tbxOutput.Content += EnigmaClass.encrypted('=');
                            keyLightUp();
                            break;
                        case Key.Add:
                            tbxInput.Text += '+';
                            tbxOutput.Content += EnigmaClass.encrypted('+');
                            keyLightUp();
                            break;
                        case Key.Multiply:
                            tbxInput.Text += '*';
                            tbxOutput.Content += EnigmaClass.encrypted('*');
                            keyLightUp();
                            break;
                        case Key.OemQuotes:
                            tbxInput.Text += '\'';
                            tbxOutput.Content += EnigmaClass.encrypted('\'');
                            keyLightUp();
                            break;
                        case Key.Space:
                            tbxInput.Text += ' ';
                            tbxOutput.Content += EnigmaClass.encrypted(' ');
                            keyLightUp();
                            break;
                            //case Key.OemQuotes:
                            //    tbxInput.Text += "'";
                            //    tbxOutput.Text += EnigmaClass.encrypted('"');
                            //    keyLightUp();
                            //    break;


                    }
                    //updateDisplayCount();
                }
            }
        }

        private void tbxInput_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (btnSetIsClicked)
            {
                switch (e.Key)
                {
                    case Key.Enter:
                        EnigmaClass.inputTextbox('\n');
                        EnigmaClass.textboxOutput.Add('\n');
                        tbxInput.Text += '\n';
                        tbxOutput.Content = '\n';
                        for (int x = 0; x < key.Length; x++)
                        {
                            key[x].Fill = originalColor;
                            keyLabels[x].Foreground = labelOriginalColor;
                        }
                        break;
                    case Key.Space:
                        tbxInput.Text += ' ';
                        tbxOutput.Content += EnigmaClass.encrypted(' ');
                        keyLightUp();
                        break;

                    case Key.Tab:
                        tbxInput.Text += "\t";
                        break;


                    case Key.Back:
                        if (tbxInput.Text.Length > 0 && ((string)tbxOutput.Content).Length > 0)
                        {
                            for (int x = EnigmaClass.textboxInput.Count - 1; x >= 0; x--)
                            {
                                if (EnigmaClass.textboxInput[x] == '\n')
                                {
                                    tbxInput.Text = EnigmaClass.backspaceInput();
                                    tbxOutput.Content = EnigmaClass.backspaceOutput();
                                    break;
                                }
                                else
                                {
                                    EnigmaClass.reverseRotor();
                                    tbxInput.Text = EnigmaClass.backspaceInput();
                                    tbxOutput.Content = EnigmaClass.backspaceOutput();
                                    break;
                                }
                            }
                        }
                        //updateDisplayCount();
                        for (int x = 0; x < key.Length; x++)
                        {
                            key[x].Fill = originalColor;
                            keyLabels[x].Foreground = labelOriginalColor;
                        }
                        break;
                }
            }
        }

        private void tbxInput_PreviewtKeyDown(object sender, KeyEventArgs e)
        {
            if (btnSetIsClicked)
            {
                switch (e.Key)
                {
                    case Key.Enter:
                        EnigmaClass.inputTextbox('\n');
                        EnigmaClass.textboxOutput.Add('\n');
                        tbxInput.Text += '\n';
                        tbxOutput.Content = '\n';
                        for (int x = 0; x < key.Length; x++)
                        {
                            key[x].Fill = originalColor;
                            keyLabels[x].Foreground = labelOriginalColor;
                        }
                        break;
                    case Key.Space:
                        tbxInput.Text += ' ';
                        tbxOutput.Content += EnigmaClass.encrypted(' ');
                        keyLightUp();
                        break;

                    case Key.Tab:
                        tbxInput.Text += "\t";
                        break;


                    case Key.Back:
                        if (tbxInput.Text.Length > 0 && ((string)tbxOutput.Content).Length > 0)
                        {
                            for (int x = EnigmaClass.textboxInput.Count - 1; x >= 0; x--)
                            {
                                if (EnigmaClass.textboxInput[x] == '\n')
                                {
                                    tbxInput.Text = EnigmaClass.backspaceInput();
                                    tbxOutput.Content = EnigmaClass.backspaceOutput();
                                    break;
                                }
                                else
                                {
                                    EnigmaClass.reverseRotor();
                                    tbxInput.Text = EnigmaClass.backspaceInput();
                                    tbxOutput.Content = EnigmaClass.backspaceOutput();
                                    break;
                                }
                            }
                        }
                        //updateDisplayCount();
                        for (int x = 0; x < key.Length; x++)
                        {
                            key[x].Fill = originalColor;
                            keyLabels[x].Foreground = labelOriginalColor;
                        }
                        break;
                }
            }
        }


        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Enigma is going to RESET setup", "Enigma", MessageBoxButton.OK, MessageBoxImage.Warning);
            if (MessageBox.Show("Are you sure you want to RESET enigma setup?", "Enigma", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //tbxRingFilePath.Text = "";
                //lblRingCount.Content = "Ring Count: ";
                //lblRingContentCount.Content = "Ring Count Content: ";
                DisableEventHandlers();
                //EnigmaClass.ClearRingLines();
                tbxInput.Text = "";
                tbxOutput.Content = "";
                cbxReflector.IsChecked = false;
                EnigmaClass.textboxInput.Clear();
                EnigmaClass.textboxOutput.Clear();
                EnigmaClass.ringSelection = new int[3] { 0, 0, 0 };
                EnigmaClass.ringSettings = new int[3] { 0, 0, 0 };
                updateDisplayCount();
                EnigmaClass.offsetRotors();
                btnSetIsClicked = false;
                DisableEventHandlers();
                btnPlusSeconds1.IsEnabled = false;
                btnPlusMinutes1.IsEnabled = false;
                btnPlusHours1.IsEnabled = false;
                btnMinusSeconds1.IsEnabled = false;
                btnMinusMinutes1.IsEnabled = false;
                btnMinusHours1.IsEnabled = false;
                btnPlusSeconds2.IsEnabled = false;
                btnPlusMinutes2.IsEnabled = false;
                btnPlusHours2.IsEnabled = false;
                btnMinusSeconds2.IsEnabled = false;
                btnMinusMinutes2.IsEnabled = false;
                btnMinusHours2.IsEnabled = false;
                btnSet.IsEnabled = false;
                cbxReflector.IsEnabled = true;
                File.IsEnabled = true;
                EnigmaClass.checkboxIsChecked = false;
                for (int x = 0; x < key.Length; x++)
                {
                    key[x].Fill = originalColor;
                    keyLabels[x].Foreground = labelOriginalColor;
                }
                MessageBox.Show("The Enigma setup is RESET.\nSelect another setup that you want.\nFeel free to select another csv file that contains rings if you want, then setup again your Enigma.", "Enigma", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isEventHandlersEnabled)
            {
                // Event handlers are disabled, do nothing
                return;
            }
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift) // Handle the Shift key
            {
                shiftKeyPressed = true;
                lbl_shift.Background = outputColor; // Change UI element appearance
                // Replace letters with symbols
                if (shiftKeyPressed)
                {
                    lbl_a.Content = "A";
                    lbl_b.Content = "B";
                    lbl_c.Content = "C";
                    lbl_d.Content = "D";
                    lbl_e.Content = "E";
                    lbl_f.Content = "F";
                    lbl_g.Content = "G";
                    lbl_h.Content = "H";
                    lbl_i.Content = "I";
                    lbl_j.Content = "J";
                    lbl_k.Content = "K";
                    lbl_l.Content = "L";
                    lbl_m.Content = "M";
                    lbl_n.Content = "N";
                    lbl_o.Content = "O";
                    lbl_p.Content = "P";
                    lbl_q.Content = "Q";
                    lbl_r.Content = "R";
                    lbl_s.Content = "S";
                    lbl_t.Content = "T";
                    lbl_u.Content = "U";
                    lbl_v.Content = "V";
                    lbl_w.Content = "W";
                    lbl_x.Content = "X";
                    lbl_y.Content = "Y";
                    lbl_z.Content = "Z";

                    // Change Symbols
                    lbl_equal.Content = "+";
                    lbl_minus.Content = "_";
                    lbl_coma.Content = "<";
                    lbl_dot.Content = ">";
                    lbl_semicolon.Content = ":";
                    lbl_qout.Content = '"';
                    slashR.Content = "?";
                    slashL.Content = "|";
                    bracketL.Content = "{";
                    bracketR.Content = "}";

                    // Replace numbers with symbols
                    lbl_1.Content = "!";
                    lbl_2.Content = "@";
                    lbl_3.Content = "#";
                    lbl_4.Content = "$";
                    lbl_5.Content = "%";
                    lbl_6.Content = "^";
                    lbl_7.Content = "&";
                    lbl_8.Content = "*";
                    lbl_9.Content = "(";
                    lbl_0.Content = ")";
                }
                return;
            }


            if (e.Key == Key.CapsLock)
            {
                capsLockEnabled = !capsLockEnabled; // Toggle Caps Lock state              
                lbl_SLock.Content = capsLockEnabled ? "Caps Lock" : "Shift Lock";  // Update your Shift Lock label text or appearance here
                lbl_SLock.Background = outputColor;
                if (capsLockEnabled)
                {
                    // Replace letters with symbols
                    lbl_a.Content = "A";
                    lbl_b.Content = "B";
                    lbl_c.Content = "C";
                    lbl_d.Content = "D";
                    lbl_e.Content = "E";
                    lbl_f.Content = "F";
                    lbl_g.Content = "G";
                    lbl_h.Content = "H";
                    lbl_i.Content = "I";
                    lbl_j.Content = "J";
                    lbl_k.Content = "K";
                    lbl_l.Content = "L";
                    lbl_m.Content = "M";
                    lbl_n.Content = "N";
                    lbl_o.Content = "O";
                    lbl_p.Content = "P";
                    lbl_q.Content = "Q";
                    lbl_r.Content = "R";
                    lbl_s.Content = "S";
                    lbl_t.Content = "T";
                    lbl_u.Content = "U";
                    lbl_v.Content = "V";
                    lbl_w.Content = "W";
                    lbl_x.Content = "X";
                    lbl_y.Content = "Y";
                    lbl_z.Content = "Z";

                    // Change Symbols
                    lbl_equal.Content = "+";
                    lbl_minus.Content = "_";
                    lbl_coma.Content = "<";
                    lbl_dot.Content = ">";
                    lbl_semicolon.Content = ":";
                    lbl_qout.Content = '"';
                    slashR.Content = "?";
                    slashL.Content = "|";
                    bracketL.Content = "{";
                    bracketR.Content = "}";

                    // Replace numbers with symbols
                    lbl_1.Content = "!";
                    lbl_2.Content = "@";
                    lbl_3.Content = "#";
                    lbl_4.Content = "$";
                    lbl_5.Content = "%";
                    lbl_6.Content = "^";
                    lbl_7.Content = "&";
                    lbl_8.Content = "*";
                    lbl_9.Content = "(";
                    lbl_0.Content = ")";
                }
                else
                {
                    // If Caps Lock is disabled, revert back to letters and numbers
                    lbl_a.Content = "a";
                    lbl_b.Content = "b";
                    lbl_c.Content = "c";
                    lbl_d.Content = "d";
                    lbl_e.Content = "e";
                    lbl_f.Content = "f";
                    lbl_g.Content = "g";
                    lbl_h.Content = "h";
                    lbl_i.Content = "i";
                    lbl_j.Content = "j";
                    lbl_k.Content = "k";
                    lbl_l.Content = "l";
                    lbl_m.Content = "m";
                    lbl_n.Content = "n";
                    lbl_o.Content = "o";
                    lbl_p.Content = "p";
                    lbl_q.Content = "q";
                    lbl_r.Content = "r";
                    lbl_s.Content = "s";
                    lbl_t.Content = "t";
                    lbl_u.Content = "u";
                    lbl_v.Content = "v";
                    lbl_w.Content = "w";
                    lbl_x.Content = "x";
                    lbl_y.Content = "y";
                    lbl_z.Content = "z";
                    lbl_equal.Content = "=";
                    lbl_minus.Content = "-";
                    lbl_coma.Content = ",";
                    lbl_dot.Content = ".";
                    lbl_semicolon.Content = ";";
                    lbl_qout.Content = "'";
                    slashL.Content = "/";
                    slashR.Content = "\\";
                    bracketL.Content = "[";
                    bracketR.Content = "]";

                    // Revert numbers back to their original values
                    lbl_1.Content = "1";
                    lbl_2.Content = "2";
                    lbl_3.Content = "3";
                    lbl_4.Content = "4";
                    lbl_5.Content = "5";
                    lbl_6.Content = "6";
                    lbl_7.Content = "7";
                    lbl_8.Content = "8";
                    lbl_9.Content = "9";
                    lbl_0.Content = "0";
                }
                return;

            }
            // Handle key press event to change the label background color.
            if (labelMappings.TryGetValue(e.Key, out var targetLabel))
            {
                targetLabel.Background = outputColor;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (!isEventHandlersEnabled)
            {
                // Event handlers are disabled, do nothing
                return;
            }

            if (shiftKeyPressed)
            {
                lbl_a.Content = "a";
                lbl_b.Content = "b";
                lbl_c.Content = "c";
                lbl_d.Content = "d";
                lbl_e.Content = "e";
                lbl_f.Content = "f";
                lbl_g.Content = "g";
                lbl_h.Content = "h";
                lbl_i.Content = "i";
                lbl_j.Content = "j";
                lbl_k.Content = "k";
                lbl_l.Content = "l";
                lbl_m.Content = "m";
                lbl_n.Content = "n";
                lbl_o.Content = "o";
                lbl_p.Content = "p";
                lbl_q.Content = "q";
                lbl_r.Content = "r";
                lbl_s.Content = "s";
                lbl_t.Content = "t";
                lbl_u.Content = "u";
                lbl_v.Content = "v";
                lbl_w.Content = "w";
                lbl_x.Content = "x";
                lbl_y.Content = "y";
                lbl_z.Content = "z";
                lbl_equal.Content = "=";
                lbl_minus.Content = "-";
                lbl_coma.Content = ",";
                lbl_dot.Content = ".";
                lbl_semicolon.Content = ";";
                lbl_qout.Content = "'";
                slashL.Content = "/";
                slashR.Content = "\\";
                bracketL.Content = "[";
                bracketR.Content = "]";

                // Revert numbers back to their original values
                lbl_1.Content = "1";
                lbl_2.Content = "2";
                lbl_3.Content = "3";
                lbl_4.Content = "4";
                lbl_5.Content = "5";
                lbl_6.Content = "6";
                lbl_7.Content = "7";
                lbl_8.Content = "8";
                lbl_9.Content = "9";
                lbl_0.Content = "0";
            }
            if (e.Key == Key.CapsLock && Keyboard.IsKeyToggled(Key.CapsLock))
            {
                return;
            }

            if (labelMappings.TryGetValue(e.Key, out var targetLabel))
            {
                targetLabel.Background = Brushes.Gray;
            }

        }


        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Do you want to CLOSE Enigma Machine?", "Enigma", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.OK)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}

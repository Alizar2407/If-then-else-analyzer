using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analyzer
{
    public partial class MainForm : Form
    {
        public static Dictionary<string, Vertex> vertices;
        public void InitializeGraph()
        {
            vertices = new Dictionary<string, Vertex>
            {
                { "S", new Vertex("S") },
                { "A", new Vertex("A") },
                { "A1", new Vertex("A1") },
                { "B", new Vertex("B") },
                { "B1", new Vertex("B1") },
                { "O2", new Vertex("O2") },
                { "O3", new Vertex("O3") },
                { "B21", new Vertex("B21") },
                { "O21", new Vertex("O21") },
                { "O31", new Vertex("O31") },
                { "O22", new Vertex("O22") },
                { "O41", new Vertex("O41") },
                { "O23", new Vertex("O23") },
                { "O4", new Vertex("O4") },
                { "B2", new Vertex("B2") },
                { "B3", new Vertex("B3") },
                { "B4", new Vertex("B4") },
                { "B22", new Vertex("B22") },
                { "B23", new Vertex("B23") },
                { "B31", new Vertex("B31") },
                { "B32", new Vertex("B32") },
                { "B33", new Vertex("B33") },
                { "B41", new Vertex("B41") },
                { "B42", new Vertex("B42") },
                { "B43", new Vertex("B43") },
                { "B44", new Vertex("B44") },
                { "B45", new Vertex("B45") },
                { "B46", new Vertex("B46") },
                { "B51", new Vertex("B51") },
                { "B61", new Vertex("B61") },
                { "CB", new Vertex("CB") },
                { "CB1", new Vertex("CB1") },
                { "CB2", new Vertex("CB2") },
                { "CB3", new Vertex("CB3") },
                { "CB4", new Vertex("CB4") },
                { "CB21", new Vertex("CB21") },
                { "CB22", new Vertex("CB22") },
                { "CB23", new Vertex("CB23") },
                { "CB31", new Vertex("CB31") },
                { "CB32", new Vertex("CB32") },
                { "CB33", new Vertex("CB33") },
                { "CB41", new Vertex("CB41") },
                { "CB42", new Vertex("CB42") },
                { "CB43", new Vertex("CB43") },
                { "CB45", new Vertex("CB45") },
                { "CB46", new Vertex("CB46") },
                { "CB51", new Vertex("CB51") },
                { "C1", new Vertex("C1") },
                { "C2", new Vertex("C2") },
                { "C3", new Vertex("C3") },
                { "C4", new Vertex("C4") },
                { "C5", new Vertex("C5") },
                { "AB", new Vertex("AB") },
                { "AB1", new Vertex("AB1") },
                { "AB21", new Vertex("AB21") },
                { "AB31", new Vertex("AB31") },
                { "AB41", new Vertex("AB41") },
                { "AB42", new Vertex("AB42") },
                { "AB43", new Vertex("AB43") },
                { "AB51", new Vertex("AB51") },
                { "C6", new Vertex("C6") },
                { "C7", new Vertex("C7") },
                { "BB", new Vertex("BB") },
                { "BB1", new Vertex("BB1") },
                { "BB2", new Vertex("BB2") },
                { "BB3", new Vertex("BB3") },
                { "BB4", new Vertex("BB4") },
                { "BB21", new Vertex("BB21") },
                { "BB22", new Vertex("BB22") },
                { "BB23", new Vertex("BB23") },
                { "BB31", new Vertex("BB31") },
                { "BB32", new Vertex("BB32") },
                { "BB33", new Vertex("BB33") },
                { "BB41", new Vertex("BB41") },
                { "BB42", new Vertex("BB42") },
                { "BB43", new Vertex("BB43") },
                { "BB45", new Vertex("BB45") },
                { "BB46", new Vertex("BB46") },
                { "BB51", new Vertex("BB51") },
                { "BB61", new Vertex("BB61") },
                { "C9", new Vertex("C9") },
                { "C12", new Vertex("C12") },
                { "C13", new Vertex("C13") },
                { "C14", new Vertex("C14") },
                { "C15", new Vertex("C15") },
                { "C30", new Vertex("C30") },
                { "C31", new Vertex("C31") },
                { "C32", new Vertex("C32") },
                { "F", new Vertex("F") }
            };

            char[] digits1 = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] digits2 = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] letters = new char[] { '_', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            vertices["S"].edges.Add(new Edge(new char[] { ' ' }, vertices["S"]));
            vertices["S"].edges.Add(new Edge(new char[] { 'i' }, vertices["A"]));
            vertices["A"].edges.Add(new Edge(new char[] { 'f' }, vertices["A1"]));
            vertices["A1"].edges.Add(new Edge(new char[] { ' ' }, vertices["B"]));
            vertices["B"].edges.Add(new Edge(new char[] { ' ' }, vertices["B"]));
            vertices["B"].edges.Add(new Edge(letters, vertices["B1"]));
            vertices["B"].edges.Add(new Edge(new char[] { '-' }, vertices["B2"]));
            vertices["B"].edges.Add(new Edge(digits1, vertices["B3"]));
            vertices["B"].edges.Add(new Edge(new char[] { '0' }, vertices["B4"]));
            vertices["B1"].edges.Add(new Edge(letters.Concat(digits2).ToArray(), vertices["B1"]));
            vertices["B1"].edges.Add(new Edge(new char[] { ' ' }, vertices["B21"]));
            vertices["B1"].edges.Add(new Edge(new char[] { '[' }, vertices["B31"]));
            vertices["B1"].edges.Add(new Edge(new char[] { '=', '#', '&', '~' }, vertices["CB"]));
            vertices["B1"].edges.Add(new Edge(new char[] { '<' }, vertices["O2"]));
            vertices["B1"].edges.Add(new Edge(new char[] { '>' }, vertices["O3"]));
            vertices["O2"].edges.Add(new Edge(new char[] { '>', '=', ' ' }, vertices["CB"]));
            vertices["O3"].edges.Add(new Edge(new char[] { '=', ' ' }, vertices["CB"]));
            vertices["B21"].edges.Add(new Edge(new char[] { '=', '#', '&', '~' }, vertices["CB"]));
            vertices["B21"].edges.Add(new Edge(new char[] { '<' }, vertices["O2"]));
            vertices["B21"].edges.Add(new Edge(new char[] { '>' }, vertices["O3"]));
            vertices["B21"].edges.Add(new Edge(new char[] { 'a' }, vertices["O21"]));
            vertices["O21"].edges.Add(new Edge(new char[] { 'n' }, vertices["O31"]));
            vertices["O31"].edges.Add(new Edge(new char[] { 'd' }, vertices["O4"]));
            vertices["B21"].edges.Add(new Edge(new char[] { 'n' }, vertices["O22"]));
            vertices["O22"].edges.Add(new Edge(new char[] { 'o' }, vertices["O41"]));
            vertices["O41"].edges.Add(new Edge(new char[] { 't' }, vertices["O4"]));
            vertices["B21"].edges.Add(new Edge(new char[] { 'o' }, vertices["O23"]));
            vertices["O23"].edges.Add(new Edge(new char[] { 'r' }, vertices["O4"]));
            vertices["O4"].edges.Add(new Edge(new char[] { ' ' }, vertices["CB"]));
            vertices["B2"].edges.Add(new Edge(digits1, vertices["B3"]));
            vertices["B2"].edges.Add(new Edge(new char[] { '0' }, vertices["B22"]));
            vertices["B3"].edges.Add(new Edge(digits2, vertices["B3"]));
            vertices["B3"].edges.Add(new Edge(new char[] { '.' }, vertices["B23"]));
            vertices["B3"].edges.Add(new Edge(new char[] { 'e' }, vertices["B33"]));
            vertices["B3"].edges.Add(new Edge(new char[] { ' ' }, vertices["B44"]));
            vertices["B3"].edges.Add(new Edge(new char[] { '=', '#', '&', '~' }, vertices["CB"]));
            vertices["B3"].edges.Add(new Edge(new char[] { '<' }, vertices["O2"]));
            vertices["B3"].edges.Add(new Edge(new char[] { '>' }, vertices["O3"]));
            vertices["B4"].edges.Add(new Edge(new char[] { '.' }, vertices["B23"]));
            vertices["B4"].edges.Add(new Edge(new char[] { ' ' }, vertices["B44"]));
            vertices["B4"].edges.Add(new Edge(new char[] { 't' }, vertices["C2"]));
            vertices["B4"].edges.Add(new Edge(new char[] { '=', '#', '&', '~' }, vertices["CB"]));
            vertices["B4"].edges.Add(new Edge(new char[] { '<' }, vertices["O2"]));
            vertices["B4"].edges.Add(new Edge(new char[] { '>' }, vertices["O3"]));
            vertices["B21"].edges.Add(new Edge(new char[] { ' ' }, vertices["B21"]));
            vertices["B21"].edges.Add(new Edge(new char[] { '[' }, vertices["B31"]));
            vertices["B21"].edges.Add(new Edge(new char[] { 't' }, vertices["C2"]));
            vertices["B22"].edges.Add(new Edge(new char[] { '.' }, vertices["B23"]));
            vertices["B23"].edges.Add(new Edge(digits2, vertices["B32"]));
            vertices["B31"].edges.Add(new Edge(new char[] { ' ' }, vertices["B31"]));
            vertices["B31"].edges.Add(new Edge(letters, vertices["B41"]));
            vertices["B31"].edges.Add(new Edge(new char[] { '-' }, vertices["B42"]));
            vertices["B31"].edges.Add(new Edge(digits1, vertices["B43"]));
            vertices["B32"].edges.Add(new Edge(digits2, vertices["B32"]));
            vertices["B32"].edges.Add(new Edge(new char[] { 'e' }, vertices["B33"]));
            vertices["B32"].edges.Add(new Edge(new char[] { ' ' }, vertices["B44"]));
            vertices["B32"].edges.Add(new Edge(new char[] { '=', '#', '&', '~' }, vertices["CB"]));
            vertices["B32"].edges.Add(new Edge(new char[] { '<' }, vertices["O2"]));
            vertices["B32"].edges.Add(new Edge(new char[] { '>' }, vertices["O3"]));
            vertices["B33"].edges.Add(new Edge(new char[] { '-' }, vertices["B45"]));
            vertices["B33"].edges.Add(new Edge(digits2, vertices["B46"]));
            vertices["B41"].edges.Add(new Edge(letters.Concat(digits2).ToArray(), vertices["B41"]));
            vertices["B41"].edges.Add(new Edge(new char[] { ' ' }, vertices["B51"]));
            vertices["B41"].edges.Add(new Edge(new char[] { ']' }, vertices["B61"]));
            vertices["B42"].edges.Add(new Edge(digits1, vertices["B43"]));
            vertices["B43"].edges.Add(new Edge(digits2, vertices["B43"]));
            vertices["B43"].edges.Add(new Edge(new char[] { ' ' }, vertices["B51"]));
            vertices["B43"].edges.Add(new Edge(new char[] { ']' }, vertices["B61"]));
            vertices["B44"].edges.Add(new Edge(new char[] { ' ' }, vertices["B44"]));
            vertices["B44"].edges.Add(new Edge(new char[] { 't' }, vertices["C2"]));
            vertices["B44"].edges.Add(new Edge(new char[] { '=', '#', '&', '~' }, vertices["CB"]));
            vertices["B44"].edges.Add(new Edge(new char[] { '<' }, vertices["O2"]));
            vertices["B44"].edges.Add(new Edge(new char[] { '>' }, vertices["O3"]));
            vertices["B44"].edges.Add(new Edge(new char[] { 'a' }, vertices["O21"]));
            vertices["B44"].edges.Add(new Edge(new char[] { 'n' }, vertices["O22"]));
            vertices["B44"].edges.Add(new Edge(new char[] { 'o' }, vertices["O23"]));
            vertices["B45"].edges.Add(new Edge(digits2, vertices["B46"]));
            vertices["B46"].edges.Add(new Edge(digits2, vertices["B46"]));
            vertices["B46"].edges.Add(new Edge(new char[] { ' ' }, vertices["B44"]));
            vertices["B46"].edges.Add(new Edge(new char[] { '=', '#', '&', '~' }, vertices["CB"]));
            vertices["B46"].edges.Add(new Edge(new char[] { '<' }, vertices["O2"]));
            vertices["B46"].edges.Add(new Edge(new char[] { '>' }, vertices["O3"]));
            vertices["B51"].edges.Add(new Edge(new char[] { ' ' }, vertices["B51"]));
            vertices["B51"].edges.Add(new Edge(new char[] { ']' }, vertices["B61"]));
            vertices["B61"].edges.Add(new Edge(new char[] { ' ' }, vertices["B61"]));
            vertices["B61"].edges.Add(new Edge(new char[] { 't' }, vertices["C2"]));
            vertices["B61"].edges.Add(new Edge(new char[] { '=', '#', '&', '~' }, vertices["CB"]));
            vertices["B61"].edges.Add(new Edge(new char[] { '<' }, vertices["O2"]));
            vertices["B61"].edges.Add(new Edge(new char[] { '>' }, vertices["O3"]));
            vertices["B61"].edges.Add(new Edge(new char[] { 'a' }, vertices["O21"]));
            vertices["B61"].edges.Add(new Edge(new char[] { 'n' }, vertices["O22"]));
            vertices["B61"].edges.Add(new Edge(new char[] { 'o' }, vertices["O23"]));
            vertices["CB"].edges.Add(new Edge(new char[] { ' ' }, vertices["CB"]));
            vertices["CB"].edges.Add(new Edge(letters, vertices["CB1"]));
            vertices["CB"].edges.Add(new Edge(new char[] { '-' }, vertices["CB2"]));
            vertices["CB"].edges.Add(new Edge(digits1, vertices["CB3"]));
            vertices["CB"].edges.Add(new Edge(new char[] { '0' }, vertices["CB4"]));
            vertices["CB1"].edges.Add(new Edge(letters.Concat(digits2).ToArray(), vertices["CB1"]));
            vertices["CB1"].edges.Add(new Edge(new char[] { ' ' }, vertices["CB21"]));
            vertices["CB1"].edges.Add(new Edge(new char[] { '[' }, vertices["CB31"]));
            vertices["CB2"].edges.Add(new Edge(digits1, vertices["CB3"]));
            vertices["CB2"].edges.Add(new Edge(new char[] { '0' }, vertices["CB22"]));
            vertices["CB3"].edges.Add(new Edge(digits2, vertices["CB3"]));
            vertices["CB3"].edges.Add(new Edge(new char[] { '.' }, vertices["CB23"]));
            vertices["CB3"].edges.Add(new Edge(new char[] { 'e' }, vertices["CB33"]));
            vertices["CB3"].edges.Add(new Edge(new char[] { ' ' }, vertices["C1"]));
            vertices["CB4"].edges.Add(new Edge(new char[] { '.' }, vertices["CB23"]));
            vertices["CB4"].edges.Add(new Edge(new char[] { ' ' }, vertices["C1"]));
            vertices["CB21"].edges.Add(new Edge(new char[] { ' ' }, vertices["CB21"]));
            vertices["CB21"].edges.Add(new Edge(new char[] { '[' }, vertices["CB31"]));
            vertices["CB21"].edges.Add(new Edge(new char[] { 't' }, vertices["C2"]));
            vertices["CB22"].edges.Add(new Edge(new char[] { '.' }, vertices["CB23"]));
            vertices["CB23"].edges.Add(new Edge(digits2, vertices["CB32"]));
            vertices["CB31"].edges.Add(new Edge(new char[] { ' ' }, vertices["CB31"]));
            vertices["CB31"].edges.Add(new Edge(letters, vertices["CB41"]));
            vertices["CB31"].edges.Add(new Edge(new char[] { '-' }, vertices["CB42"]));
            vertices["CB31"].edges.Add(new Edge(digits1, vertices["CB43"]));
            vertices["CB32"].edges.Add(new Edge(digits2, vertices["CB32"]));
            vertices["CB32"].edges.Add(new Edge(new char[] { 'e' }, vertices["CB33"]));
            vertices["CB32"].edges.Add(new Edge(new char[] { ' ' }, vertices["C1"]));
            vertices["CB33"].edges.Add(new Edge(new char[] { '-' }, vertices["CB45"]));
            vertices["CB33"].edges.Add(new Edge(digits2, vertices["CB46"]));
            vertices["CB41"].edges.Add(new Edge(letters.Concat(digits2).ToArray(), vertices["CB41"]));
            vertices["CB41"].edges.Add(new Edge(new char[] { ' ' }, vertices["CB51"]));
            vertices["CB41"].edges.Add(new Edge(new char[] { ']' }, vertices["C1"]));
            vertices["CB42"].edges.Add(new Edge(digits1, vertices["CB43"]));
            vertices["CB43"].edges.Add(new Edge(digits2, vertices["CB43"]));
            vertices["CB43"].edges.Add(new Edge(new char[] { ' ' }, vertices["CB51"]));
            vertices["CB43"].edges.Add(new Edge(new char[] { ']' }, vertices["C1"]));
            vertices["CB45"].edges.Add(new Edge(digits2, vertices["CB46"]));
            vertices["CB46"].edges.Add(new Edge(digits2, vertices["CB46"]));
            vertices["CB46"].edges.Add(new Edge(new char[] { ' ' }, vertices["C1"]));
            vertices["CB51"].edges.Add(new Edge(new char[] { ' ' }, vertices["CB51"]));
            vertices["CB51"].edges.Add(new Edge(new char[] { ']' }, vertices["C1"]));
            vertices["C1"].edges.Add(new Edge(new char[] { ' ' }, vertices["C1"]));
            vertices["C1"].edges.Add(new Edge(new char[] { 't' }, vertices["C2"]));
            vertices["C2"].edges.Add(new Edge(new char[] { 'h' }, vertices["C3"]));
            vertices["C3"].edges.Add(new Edge(new char[] { 'e' }, vertices["C4"]));
            vertices["C4"].edges.Add(new Edge(new char[] { 'n' }, vertices["C5"]));
            vertices["C5"].edges.Add(new Edge(new char[] { ' ' }, vertices["AB"]));
            vertices["AB"].edges.Add(new Edge(new char[] { ' ' }, vertices["AB"]));
            vertices["AB"].edges.Add(new Edge(letters, vertices["AB1"]));
            vertices["AB1"].edges.Add(new Edge(letters.Concat(digits2).ToArray(), vertices["AB1"]));
            vertices["AB1"].edges.Add(new Edge(new char[] { ' ' }, vertices["AB21"]));
            vertices["AB1"].edges.Add(new Edge(new char[] { '[' }, vertices["AB31"]));
            vertices["AB1"].edges.Add(new Edge(new char[] { ':' }, vertices["C7"]));
            vertices["AB21"].edges.Add(new Edge(new char[] { ' ' }, vertices["AB21"]));
            vertices["AB21"].edges.Add(new Edge(new char[] { '[' }, vertices["AB31"]));
            vertices["AB21"].edges.Add(new Edge(new char[] { ':' }, vertices["C7"]));
            vertices["AB31"].edges.Add(new Edge(new char[] { ' ' }, vertices["AB31"]));
            vertices["AB31"].edges.Add(new Edge(letters, vertices["AB41"]));
            vertices["AB31"].edges.Add(new Edge(new char[] { '-' }, vertices["AB42"]));
            vertices["AB31"].edges.Add(new Edge(digits1, vertices["AB43"]));
            vertices["AB41"].edges.Add(new Edge(letters.Concat(digits2).ToArray(), vertices["AB41"]));
            vertices["AB41"].edges.Add(new Edge(new char[] { ' ' }, vertices["AB51"]));
            vertices["AB41"].edges.Add(new Edge(new char[] { ']' }, vertices["C6"]));
            vertices["AB42"].edges.Add(new Edge(digits1, vertices["AB43"]));
            vertices["AB43"].edges.Add(new Edge(digits2, vertices["AB43"]));
            vertices["AB43"].edges.Add(new Edge(new char[] { ' ' }, vertices["AB51"]));
            vertices["AB43"].edges.Add(new Edge(new char[] { ']' }, vertices["C6"]));
            vertices["AB51"].edges.Add(new Edge(new char[] { ' ' }, vertices["AB51"]));
            vertices["AB51"].edges.Add(new Edge(new char[] { ']' }, vertices["C6"]));
            vertices["C6"].edges.Add(new Edge(new char[] { ' ' }, vertices["C6"]));
            vertices["C6"].edges.Add(new Edge(new char[] { ':' }, vertices["C7"]));
            vertices["C7"].edges.Add(new Edge(new char[] { '=' }, vertices["BB"]));
            vertices["BB"].edges.Add(new Edge(new char[] { ' ' }, vertices["BB"]));
            vertices["BB"].edges.Add(new Edge(letters, vertices["BB1"]));
            vertices["BB"].edges.Add(new Edge(new char[] { '-' }, vertices["BB2"]));
            vertices["BB"].edges.Add(new Edge(digits1, vertices["BB3"]));
            vertices["BB"].edges.Add(new Edge(new char[] { '0' }, vertices["BB4"]));
            vertices["BB1"].edges.Add(new Edge(letters.Concat(digits2).ToArray(), vertices["BB1"]));
            vertices["BB1"].edges.Add(new Edge(new char[] { ' ' }, vertices["BB21"]));
            vertices["BB1"].edges.Add(new Edge(new char[] { '[' }, vertices["BB31"]));
            vertices["BB2"].edges.Add(new Edge(digits1, vertices["BB3"]));
            vertices["BB2"].edges.Add(new Edge(new char[] { '0' }, vertices["BB22"]));
            vertices["BB3"].edges.Add(new Edge(digits2, vertices["BB3"]));
            vertices["BB3"].edges.Add(new Edge(new char[] { '.' }, vertices["BB23"]));
            vertices["BB3"].edges.Add(new Edge(new char[] { 'e' }, vertices["BB33"]));
            vertices["BB3"].edges.Add(new Edge(new char[] { ' ' }, vertices["C9"]));
            vertices["BB4"].edges.Add(new Edge(new char[] { '.' }, vertices["BB23"]));
            vertices["BB4"].edges.Add(new Edge(new char[] { ' ' }, vertices["C9"]));
            vertices["BB21"].edges.Add(new Edge(new char[] { ' ' }, vertices["BB21"]));
            vertices["BB21"].edges.Add(new Edge(new char[] { '[' }, vertices["BB31"]));
            vertices["BB21"].edges.Add(new Edge(new char[] { 'e' }, vertices["C30"]));
            vertices["BB22"].edges.Add(new Edge(new char[] { '.' }, vertices["BB23"]));
            vertices["BB23"].edges.Add(new Edge(digits2, vertices["BB32"]));
            vertices["BB31"].edges.Add(new Edge(new char[] { ' ' }, vertices["BB31"]));
            vertices["BB31"].edges.Add(new Edge(letters, vertices["BB41"]));
            vertices["BB31"].edges.Add(new Edge(new char[] { '-' }, vertices["BB42"]));
            vertices["BB31"].edges.Add(new Edge(digits1, vertices["BB43"]));
            vertices["BB32"].edges.Add(new Edge(digits2, vertices["BB32"]));
            vertices["BB32"].edges.Add(new Edge(new char[] { 'e' }, vertices["BB33"]));
            vertices["BB32"].edges.Add(new Edge(new char[] { ' ' }, vertices["C9"]));
            vertices["BB33"].edges.Add(new Edge(new char[] { '-' }, vertices["BB45"]));
            vertices["BB33"].edges.Add(new Edge(digits2, vertices["BB46"]));
            vertices["BB41"].edges.Add(new Edge(letters.Concat(digits2).ToArray(), vertices["BB41"]));
            vertices["BB41"].edges.Add(new Edge(new char[] { ' ' }, vertices["BB51"]));
            vertices["BB41"].edges.Add(new Edge(new char[] { ']' }, vertices["BB61"]));
            vertices["BB42"].edges.Add(new Edge(digits1, vertices["BB43"]));
            vertices["BB43"].edges.Add(new Edge(digits2, vertices["BB43"]));
            vertices["BB43"].edges.Add(new Edge(new char[] { ' ' }, vertices["BB51"]));
            vertices["BB43"].edges.Add(new Edge(new char[] { ']' }, vertices["BB61"]));
            vertices["BB45"].edges.Add(new Edge(digits2, vertices["BB46"]));
            vertices["BB46"].edges.Add(new Edge(digits2, vertices["BB46"]));
            vertices["BB46"].edges.Add(new Edge(new char[] { ' ' }, vertices["C9"]));
            vertices["BB51"].edges.Add(new Edge(new char[] { ' ' }, vertices["BB51"]));
            vertices["BB51"].edges.Add(new Edge(new char[] { ']' }, vertices["BB61"]));
            vertices["BB61"].edges.Add(new Edge(new char[] { ' ' }, vertices["C9"]));
            vertices["C9"].edges.Add(new Edge(new char[] { ' ' }, vertices["C9"]));
            vertices["C9"].edges.Add(new Edge(new char[] { 'e' }, vertices["C30"]));
            vertices["C30"].edges.Add(new Edge(new char[] { 'l' }, vertices["C12"]));
            vertices["C12"].edges.Add(new Edge(new char[] { 's' }, vertices["C13"]));
            vertices["C13"].edges.Add(new Edge(new char[] { 'i' }, vertices["C14"]));
            vertices["C14"].edges.Add(new Edge(new char[] { 'f' }, vertices["C15"]));
            vertices["C15"].edges.Add(new Edge(new char[] { ' ' }, vertices["B"]));
            vertices["C30"].edges.Add(new Edge(new char[] { 'n' }, vertices["C31"]));
            vertices["C31"].edges.Add(new Edge(new char[] { 'd' }, vertices["C32"]));
            vertices["C32"].edges.Add(new Edge(new char[] { ';' }, vertices["F"]));
            vertices["C32"].edges.Add(new Edge(new char[] { ' ' }, vertices["C32"]));
        }

        public MainForm()
        {
            InitializeComponent();

            InitializeGraph();
        }

        public bool CheckSyntax(string str)
        {
            Vertex currentVertex = new Vertex("S");
            currentVertex.edges = new List<Edge>(vertices["S"].edges);

            int index = 0;

            while (currentVertex.name != "F" && currentVertex.name != "E" && index < str.Length)
                currentVertex.Forward(str[index++]);

            if (currentVertex.name != "F")
            {
                string expectedSymbols = string.Empty;
                foreach (Edge edge in currentVertex.edges)
                {
                    foreach (char c in edge.symbols)
                    {
                        if (c != ' ')
                            expectedSymbols += c;
                        else
                            expectedSymbols += "space";

                        expectedSymbols += ", ";
                    }
                }
                expectedSymbols = expectedSymbols.Remove(expectedSymbols.Length - 2);

                if (currentVertex.name == "E")
                {
                    this.syntaxErrorsTextBox.AppendText($"Ошибка : недопустимый символ - '{str[index - 1]}'" + Environment.NewLine);
                    this.syntaxErrorsTextBox.AppendText($"номер символа - {index}" + Environment.NewLine + Environment.NewLine);

                    this.syntaxErrorsTextBox.AppendText($"Ожидалось : {expectedSymbols}");

                    this.inputTextbox.Focus();
                    this.inputTextbox.SelectionStart = index - 1;
                    this.inputTextbox.SelectionLength = 1;
                }
                else
                {
                    this.syntaxErrorsTextBox.AppendText($"Ожидалось : {expectedSymbols}");

                    this.inputTextbox.Focus();
                    this.inputTextbox.SelectionStart = str.Length;
                }
            }

            return currentVertex.name == "F";
        }

        public List<(string, int)> ReadSegments(string str, string[] ways)
        {
            Vertex currentVertex = new Vertex("S");
            currentVertex.edges = new List<Edge>(vertices["S"].edges);
            int index = 0;

            List<(string, int)> segments = new List<(string, int)>();

            string[] startStates = (from way in ways select way.Split('-')[0]).ToArray();

            do
            {
                while (!startStates.Contains(currentVertex.name) && currentVertex.name != "F" && currentVertex.name != "E" && index < str.Length)
                    currentVertex.Forward(str[index++]);

                string startState = currentVertex.name;

                if (startState == "E" || startState == "F")
                    return segments;

                int segmentStart = index;
                string segment = string.Empty;
                string segmentWay = string.Empty;

                while (currentVertex.name != "F" && currentVertex.name != "E" && index < str.Length)
                {
                    if (segmentWay == string.Empty)
                        segmentWay += currentVertex.name;
                    else if (segmentWay.Split('-').Last() != currentVertex.name)
                        segmentWay += "-" + currentVertex.name;

                    if (!ways.Any(way => (way + "-").StartsWith(segmentWay + "-")))
                        break;

                    currentVertex.Forward(str[index]);
                    segment += str[index];
                    ++index;
                }

                if (segment.Length > 0)
                {
                    segment = segment.Remove(segment.Length - 1);
                    segmentWay = segmentWay.Remove(segmentWay.LastIndexOf('-'));

                    if (ways.Contains(segmentWay))
                        segments.Add((segment, segmentStart));
                }
            }
            while (currentVertex.name != "F" && currentVertex.name != "E");

            return segments;
        }

        public bool CheckSemantics(string str)
        {
            string[] mantissaWays =
            {
                "B-B3", "B-B3-B23-B32",
                "B2-B3", "B2-B3-B23-B32",
                "B-B4-B23-B32",
                "B2-B22-B23-B32",

                "CB-CB3", "CB-CB3-CB23-CB32",
                "CB2-CB3", "CB2-CB3-CB23-CB32",
                "CB-CB4-CB23-CB32",
                "CB2-CB22-CB23-CB32",

                "BB-BB3", "BB-BB3-BB23-BB32",
                "BB2-BB3", "BB2-BB3-BB23-BB32",
                "BB-BB4-BB23-BB32",
                "BB2-BB22-BB23-BB32",
            };
            List<(string segment, int start)> mantisses = ReadSegments(str, mantissaWays);

            foreach (var mantissa in mantisses)
            {
                if (mantissa.segment.Length > 15)
                {
                    this.semanticsErrorsTextBox.AppendText("Длина мантиссы не должна быть больше 15" + Environment.NewLine);
                    this.inputTextbox.Focus();
                    this.inputTextbox.SelectionStart = mantissa.start;
                    this.inputTextbox.SelectionLength = mantissa.segment.Length;
                    return false;
                }
            }

            //---------------------------------------------------------------------------------------------------------------
            
            string[] integerWays =
            {
                "B-B3", "B-B2-B3", "B-B4",
                "B31-B43", "B31-B42-B43",

                "CB-CB3", "CB-CB2-CB3", "CB-CB4",
                "CB31-CB43", "CB31-CB42-CB43",

                "AB-AB3", "AB-AB2-AB3", "AB-AB4",
                "AB31-AB43", "AB31-AB42-AB43",

                "BB-BB3", "BB-BB2-BB3", "BB-BB4",
                "BB31-BB43", "BB31-BB42-BB43",
            };
            List<(string segment, int start)> integers = ReadSegments(str, integerWays);

            foreach (var integer in integers)
            {
                if (!new char[] { '.', 'e' }.Contains(str[integer.start + integer.segment.Length]))
                {
                    if (!int.TryParse(integer.segment, out int result) || !(-32768 <= result && result <= 32767))
                    {
                        this.semanticsErrorsTextBox.AppendText("целое число должно быть в пределах от -32768 до 32767" + Environment.NewLine);
                        this.inputTextbox.Focus();
                        this.inputTextbox.SelectionStart = integer.start;
                        this.inputTextbox.SelectionLength = integer.segment.Length;
                        return false;
                    }
                }
            }

            //---------------------------------------------------------------------------------------------------------------

            string[] idWays =
            {
                "B-B1", "B31-B41",
                "CB-CB1", "CB31-CB41",
                "AB-AB1", "AB31-AB41",
                "BB-BB1", "BB31-BB41",
            };
            List<(string segment, int start)> ids = ReadSegments(str, idWays);

            foreach (var id in ids)
            {
                string[] keywords = { "if", "then", "elsif", "else", "end", "or", "not", "and" };

                if (id.segment.Trim().Length > 8 || keywords.Contains(id.segment))
                {
                    this.semanticsErrorsTextBox.AppendText("длина идентификатора должна быть не больше 8, и он не должен совпадать с ключевыми словами if, then, ..." + Environment.NewLine);
                    this.inputTextbox.Focus();
                    this.inputTextbox.SelectionStart = id.start;
                    this.inputTextbox.SelectionLength = id.segment.Length;
                    return false;
                }
            }

            //---------------------------------------------------------------------------------------------------------------

            return true;
        }

        public void PrintTable(string str)
        {
            string[] idWays =
            {
                "B-B1", "B31-B41",
                "CB-CB1", "CB31-CB41",
                "AB-AB1", "AB31-AB41",
                "BB-BB1", "BB31-BB41",
            };
            List<(string segment, int start)> ids = ReadSegments(str, idWays);

            this.semanticsErrorsTextBox.AppendText("Идентификаторы:" + Environment.NewLine);
            for (int i = 0; i < ids.Count; ++i)
            {
                string id = ids[i].segment.Trim();

                bool flag = false;
                for (int j = 0; j < i; ++j)
                {
                    if (id == ids[j].segment)
                        flag = true;
                }

                if (!flag)
                    this.semanticsErrorsTextBox.AppendText(id + Environment.NewLine);
            }

            //---------------------------------------------------------------------------------------------------------------

            string[] cardinalConstantWays =
            {
                "B31-B43", "B31-B42-B43",
                "CB31-CB43", "CB31-CB42-CB43",
                "AB31-AB43", "AB31-AB42-AB43",
                "BB31-BB43", "BB31-BB42-BB43",
            };
            List<(string segment, int start)> cardinalConstants = ReadSegments(str, cardinalConstantWays);

            string[] realConstantWays =
            {
                "B-B4",
                "B-B4-B23-B32",
                "B-B4-B23-B32-B33-B46",
                "B-B4-B23-B32-B33-B45-B46",
                "B-B2-B22-B23-B32",
                "B-B2-B22-B23-B32-B33-B46",
                "B-B2-B22-B23-B32-B33-B45-B46",
                "B-B2-B3",
                "B-B2-B3-B23-B32",
                "B-B2-B3-B23-B32-B33-B46",
                "B-B2-B3-B23-B32-B33-B45-B46",
                "B-B2-B3-B33-B46",
                "B-B2-B3-B33-B45-B46",
                "B-B3",
                "B-B3-B23-B32",
                "B-B3-B23-B32-B33-B46",
                "B-B3-B23-B32-B33-B45-B46",
                "B-B3-B33-B46",
                "B-B3-B33-B45-B46",

                "CB-CB4",
                "CB-CB4-CB23-CB32",
                "CB-CB4-CB23-CB32-CB33-CB46",
                "CB-CB4-CB23-CB32-CB33-CB45-CB46",
                "CB-CB2-CB22-CB23-CB32",
                "CB-CB2-CB22-CB23-CB32-CB33-CB46",
                "CB-CB2-CB22-CB23-CB32-CB33-CB45-CB46",
                "CB-CB2-CB3",
                "CB-CB2-CB3-CB23-CB32",
                "CB-CB2-CB3-CB23-CB32-CB33-CB46",
                "CB-CB2-CB3-CB23-CB32-CB33-CB45-CB46",
                "CB-CB2-CB3-CB33-CB46",
                "CB-CB2-CB3-CB33-CB45-CB46",
                "CB-CB3",
                "CB-CB3-CB23-CB32",
                "CB-CB3-CB23-CB32-CB33-CB46",
                "CB-CB3-CB23-CB32-CB33-CB45-CB46",
                "CB-CB3-CB33-CB46",
                "CB-CB3-CB33-CB45-CB46",

                "BB-BB4",
                "BB-BB4-BB23-BB32",
                "BB-BB4-BB23-BB32-BB33-BB46",
                "BB-BB4-BB23-BB32-BB33-BB45-BB46",
                "BB-BB2-BB22-BB23-BB32",
                "BB-BB2-BB22-BB23-BB32-BB33-BB46",
                "BB-BB2-BB22-BB23-BB32-BB33-BB45-BB46",
                "BB-BB2-BB3",
                "BB-BB2-BB3-BB23-BB32",
                "BB-BB2-BB3-BB23-BB32-BB33-BB46",
                "BB-BB2-BB3-BB23-BB32-BB33-BB45-BB46",
                "BB-BB2-BB3-BB33-BB46",
                "BB-BB2-BB3-BB33-BB45-BB46",
                "BB-BB3",
                "BB-BB3-BB23-BB32",
                "BB-BB3-BB23-BB32-BB33-BB46",
                "BB-BB3-BB23-BB32-BB33-BB45-BB46",
                "BB-BB3-BB33-BB46",
                "BB-BB3-BB33-BB45-BB46",
            };
            List<(string segment, int start)> realConstants = ReadSegments(str, realConstantWays);

            this.semanticsErrorsTextBox.AppendText("Константы:" + Environment.NewLine);
            foreach (var constant in cardinalConstants)
                this.semanticsErrorsTextBox.AppendText("CARDINAL " + constant.segment + Environment.NewLine);
            foreach (var constant in realConstants)
                this.semanticsErrorsTextBox.AppendText("REAL " + constant.segment + Environment.NewLine);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            this.syntaxErrorsTextBox.Clear();
            this.semanticsErrorsTextBox.Clear();

            bool syntaxFlag = CheckSyntax(this.inputTextbox.Text.ToLower());

            if (syntaxFlag)
                this.syntaxErrorsTextBox.AppendText("Синтаксических ошибок нет");
            else
                this.syntaxErrorsTextBox.AppendText(Environment.NewLine + Environment.NewLine + "Цепочка не подходит");

            if (syntaxFlag)
            {
                bool semanticsFlag = CheckSemantics(this.inputTextbox.Text.ToLower());

                if (semanticsFlag)
                {
                    this.semanticsErrorsTextBox.AppendText("Семантических ошибок нет");

                    this.semanticsErrorsTextBox.AppendText(Environment.NewLine + Environment.NewLine);
                    PrintTable(this.inputTextbox.Text.ToLower());
                }
                else
                {
                    this.semanticsErrorsTextBox.AppendText(Environment.NewLine + Environment.NewLine + "Цепочка не подходит");
                }
            }
        }
    }
}

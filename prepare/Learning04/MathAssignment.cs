using System;

public class MathAssignment : Assignment {
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment(string studentName, string topic, string texbookSection, string problems): base(studentName, topic) {
            _textbookSection = texbookSection;
            _problems = problems;
    }

    public string GetHomeworkList() {
        return $"{GetSummary()}\n{_textbookSection}, {_problems}";
    }
}
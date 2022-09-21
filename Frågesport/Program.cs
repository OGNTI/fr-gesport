int score;
int questions;
string answer1;
string yesNo1;

Console.WriteLine("Start Quiz?");
yesNo1 = Console.ReadLine();
string yesNo2 = yesNo1.ToLower();

if (yesNo2 != "yes")
{
    Environment.Exit(0);
}

void quiz(){
    score = 0;
    questions = 0;
    Console.Clear();
    questions++;
    Console.WriteLine("What is 1 + 1?");
    Console.WriteLine("Is it, A:8, B:25 or C:2.");
    answer1 = Console.ReadLine();
    string answer2 = answer1.ToLower();

    if (answer2 != "c")
    {
        Console.WriteLine("Do you not know 1+1 you dumb fuck.");
        Console.WriteLine("Restart?");
        yesNo1 = Console.ReadLine();
        yesNo2 = yesNo1.ToLower();

        if (yesNo2 == "yes" || yesNo2 == "sure" || yesNo2 == "ok")
        {
            quiz();
        }
        else
        {
            Environment.Exit(0);
        }
    }
    else
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("What is the complementary colour of brown?");
    Console.WriteLine("Is it, A: Blue, B: Yellow or C: Green");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "c")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("What is the eighth month of the year?");
    Console.WriteLine("A: September, B: July or C: August");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "c")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("How many chairs were there in the classroom A1 on the 21 of september 2022?");
    Console.WriteLine("A: 31, B: 36 or C: 34");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "c")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("The Erector Spinae Muscle lies in which part of the human body?");
    Console.WriteLine("A: Legs, B: Back or C: Chest");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "b")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("Sweetango is a variety of which fruit?");
    Console.WriteLine("A: Mango, B: Orange or C: Apple");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "c")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("During which month does the Summer Solstice occur in the Southern Hemisphere?");
    Console.WriteLine("A: January, B: June or C: December");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "c")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("What year did a man first walk on the moon?");
    Console.WriteLine("A: 1964, B: 1967 or C: 1969");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "c")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("Roman Emperor Gaius Julius Caesar Augustus Germanicus is better known by what name?");
    Console.WriteLine("A: Marcus Aurelius, B: Caligula or C: Nero");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "b")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("Taphophobia is the fear of what?");
    Console.WriteLine("A: Tapdancing, B: Standing in queues or C: Being buried alive");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "c")
    {
        score++;
    }

    Console.Clear();
    questions++;
    Console.WriteLine("Which of the following vegetables has the highest Folic Acid content?");
    Console.WriteLine("A: Turnip, B: Potato or C: Broccoli");
    answer1 = Console.ReadLine();
    answer2 = answer1.ToLower();

    if (answer2 == "c")
    {
        score++;
    }

    Console.WriteLine("Congratualations you got to the end of the quiz.");
    Console.WriteLine($"You got {score}/{questions} questions right.");
    Console.WriteLine("Do you want to play again?");
    yesNo1 = Console.ReadLine();
    yesNo2 = yesNo1.ToLower();

    if (yesNo2 == "yes" || yesNo2 == "sure" || yesNo2 == "ok")
    {
        quiz();
    }
    else
    {
        Environment.Exit(0);
    }
}

quiz();

// Question Template
// Console.Clear();
//     questions++;
//     Console.WriteLine("");
//     Console.WriteLine("A: , B:  or C: ");
//     answer1 = Console.ReadLine();
//     answer2 = answer1.ToLower();

//     if (answer2 == "")
//     {
//         score++;
//     }
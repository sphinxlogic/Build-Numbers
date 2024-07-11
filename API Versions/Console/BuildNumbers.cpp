#include <tchar.h>

#using <mscorlib.dll>
#using <System.xml.dll>

using namespace System;
using namespace System::Xml;

void _tmain(void)
{
    XmlTextReader^ reader = gcnew XmlTextReader("data.xml");

    while (reader->Read())
    {
        switch (reader->NodeType)
        {
        case XmlNodeType::Element: // The node is an element.
            Console::Write("<{0}", reader->Name);

            while (reader->MoveToNextAttribute()) // Read the attributes.
                Console::Write(" {0}='{1}'", reader->Name, reader->Value);
            Console::WriteLine(">");
            break;
        case XmlNodeType::Text: //Display the text in each element.
            Console::WriteLine(reader->Value);
            break;
        case XmlNodeType::EndElement: //Display the end of the element.
            Console::Write("</{0}", reader->Name);
            Console::WriteLine(">");
            break;
        }
    }
    Console::ReadLine();
}
// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

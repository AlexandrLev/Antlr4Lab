grammar lab;
options 
{language = CSharp;}

ab	: (A|Sum|B)*;

A	:	'A'|'a';
B	:	'B'|'b';
Sum	:	'+';
WS  
    :   (' ' | '\t' | '\r'| '\n') -> skip
    ;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Javalib\lab.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class labLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		A=1, B=2, Sum=3, WS=4;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"A", "B", "Sum", "WS"
	};


	public labLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public labLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, "'+'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "A", "B", "Sum", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "lab.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static labLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x6', '\x15', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x2', '\x2', '\x6', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', 
		'\x6', '\x3', '\x2', '\x5', '\x4', '\x2', '\x43', '\x43', '\x63', '\x63', 
		'\x4', '\x2', '\x44', '\x44', '\x64', '\x64', '\x5', '\x2', '\v', '\f', 
		'\xF', '\xF', '\"', '\"', '\x2', '\x14', '\x2', '\x3', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x3', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x5', '\r', '\x3', '\x2', '\x2', '\x2', '\a', '\xF', 
		'\x3', '\x2', '\x2', '\x2', '\t', '\x11', '\x3', '\x2', '\x2', '\x2', 
		'\v', '\f', '\t', '\x2', '\x2', '\x2', '\f', '\x4', '\x3', '\x2', '\x2', 
		'\x2', '\r', '\xE', '\t', '\x3', '\x2', '\x2', '\xE', '\x6', '\x3', '\x2', 
		'\x2', '\x2', '\xF', '\x10', '\a', '-', '\x2', '\x2', '\x10', '\b', '\x3', 
		'\x2', '\x2', '\x2', '\x11', '\x12', '\t', '\x4', '\x2', '\x2', '\x12', 
		'\x13', '\x3', '\x2', '\x2', '\x2', '\x13', '\x14', '\b', '\x5', '\x2', 
		'\x2', '\x14', '\n', '\x3', '\x2', '\x2', '\x2', '\x3', '\x2', '\x3', 
		'\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}

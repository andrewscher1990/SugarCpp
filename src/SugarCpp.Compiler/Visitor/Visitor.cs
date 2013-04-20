﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.StringTemplate;

namespace SugarCpp.Compiler
{
    public abstract class Visitor
    {
        public abstract Template Visit(Root root);

        public abstract Template Visit(Import import);

        public abstract Template Visit(FuncDef func_def);
        public abstract Template Visit(StmtBlock block);

        public abstract Template Visit(StmtIf stmt_if);
        public abstract Template Visit(StmtWhile stmt_while);

        public abstract Template Visit(ExprAssign expr);
        public abstract Template Visit(ExprBin expr);
        public abstract Template Visit(ExprAlloc expr);
        public abstract Template Visit(ExprConst expr);
    }
}

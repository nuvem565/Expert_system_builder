﻿module SimpleParsers

open FParsec
open System.Collections.Generic

// AUXILIARY PARSER FUNCTIONS

let ws = spaces 
let ws1 = spaces1
let ch c = pchar c
let str s = skipString s
let strCI s = skipStringCI s
let str_ws s = skipString s >>. ws
let strCI_ws s = skipStringCI s >>. ws
let ws_str s = skipStringCI s .>> ws
let ws_strCI s = skipStringCI s .>> ws


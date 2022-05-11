#r "/home/hojelse/fsharp-tools/FsLexYacc.Runtime.dll"
#load "Absyn.fs"
#load "Fun.fs"
#load "FunPar.fs"
#load "FunLex.fs"
#load "Parse.fs"
#load "HigherFun.fs"
#load "ParseAndRun.fs"
#load "ParseAndRunHigher.fs"
#load "TypeInference.fs"
#load "ParseAndType.fs"
// #load "ListCC.fs"

open Absyn;;
open Fun;;
open FunPar;;
open FunPar;;
open FunLex;;
open Parse;;
open HigherFun;;
open ParseAndRun;;
open ParseAndRunHigher;;
open TypeInference;;
open ParseAndType;;

(* 1.1 *)

let ex01 = @"let s1 = {2, 3} in
    let s2 = {1, 4} in
      s1 ++ s2 = {2,4,3,1}
  end
end"
;;

ParseAndType.fromString ex01
;;

ParseAndType.fromString @"let s1 = { } in
    let s2 = {1, 4} in
      s1 ++ s2 = {2,4,3,1}
  end
end"
;;

(* 1.3 *)
ParseAndRunHigher.eval (ParseAndType.fromString ex01) [];;
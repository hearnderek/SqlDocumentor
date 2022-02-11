# Project Summary


# Tasks

- [TODO] Define requirements
  - I'm thinking of Building an object representation on top of the 
- [TODO] Decide scope
- [TODO] Pullin columns names for each table, so implist table references can be calculated.

# Event Log

[2022-02-11]
1. [Action] Created project
2. [Decision] Decided on project goals
   1. get more familier with Microsoft.SqlServer.Management.SqlParser
   2. build a tool that can document the computation flow through a complex SQL Script
3. [Decision] Use a Project log 
   1. Descending INI style date headers 
   2. Numbered events within day
   3. ignoring time granularity
   4. INI style tags at beginning of lines
4. [Action] Added Test Project
5. [Error] BadImageFormatException
6. [Resulution] Run in 64bit
7. [Decision] Set all build options to target ONLY 64bit -- Should be looked into further
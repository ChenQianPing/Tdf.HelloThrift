/*
 * Apache Thrift - 可伸缩的跨语言服务开发框架
 * 
 * Thrift是一款由Fackbook开发的可伸缩、跨语言的服务开发框架，
 * 该框架已经开源并且加入的Apache项目。
 * Thrift主要功能是：通过自定义的Interface Definition Language(IDL)，
 * 可以创建基于RPC的客户端和服务端的服务代码。
 * 数据和服务代码的生成是通过Thrift内置的代码生成器来实现的。
 * Thrift 的跨语言性体现在，
 * 
 * 它可以生成C++, Java, Python, PHP, Ruby, Erlang, Perl, Haskell, C#, 
 * Cocoa, JavaScript, Node.js, Smalltalk, OCaml , Delphi等语言的代码，
 * 且它们之间可以进行透明的通信。
 * 
 * # 数据类型
 Thrift 脚本可定义的数据类型包括以下几种类型：
 # 基本类型：
bool：布尔值，true 或 false，对应 C#的 bool
byte：8 位有符号整数，对应 C#的 byte
i16：16 位有符号整数，对应 C#的 short
i32：32 位有符号整数，对应 C#的 int
i64：64 位有符号整数，对应 C#的 long
double：64 位浮点数，对应 C#的 double
string：未知编码文本或二进制字符串，对应 C#的 string

#结构体类型：
struct：定义公共的对象，类似于 C 语言中的结构体定义，在 C#中是一个实体类

# 容器类型：

list：对应 C#的 List<T> 有序集合
set：对应 C#的 HashSet<T>无序但是不能重复的集合
map：对应 C#的 Dictionary<TKey,TValue>键值对集合，键不能重复

# 异常类型：
exception：对应 C#的 Exception

# 服务类型：
service：对应服务的类

IDL编译工具。官方本身提供了Windows的exe版本
thrift-0.9.2 -gen csharp Hello.thrift
thrift-0.9.2 -gen csharp User.Thrift

Thrift类库。Thrift底层框架，提供了底层的数据传输服务。

 */ 
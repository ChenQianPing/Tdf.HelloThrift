namespace csharp HelloThrift.Interface

struct User{
  1:i32 Id, //编号
  2:string UserName, //用户名
  3:string UserPass, //密码
  4:string Email,    //邮箱
  5:string RegTime,  //注册时间
}


service UserService{
   User GetUserById(1:i32 id) //获取指定用户信息
   list<User> GetAllUser()    //获取所有用户信息
   list<User> GetUserByPageIndex(1:i32 pageIndex,2:i32 pageSize) //获取指定页面用户信息
   i32 GetUserCount()    //获取用户总数
   bool Add(1:User user) //注册用户信息
   bool Update(1:User user) //更新用户信息
   bool Delete(1:i32 id)    //删除指定用户信息
}

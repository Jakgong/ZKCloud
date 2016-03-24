﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZKCloud.Localize;

namespace ZKCloud.Web.Apps.demo01.src.Translates {
    public class zh_CN : ITranslateProvider {
        private static HashSet<string> _codes = new HashSet<string>() { "zh-CN" };

        private static Dictionary<string, string> _translates = new Dictionary<string, string>()
        {
            { "aaaa", "啊啊啊啊" },
            { "Admin Login", "管理员登陆" },
            { "Please enter username", "请填写用户名" },
            { "Please enter password", "请填写密码" },
            { "Username", "用户名" },
            { "Password", "密码" },
            { "Login", "登陆" },
            { "Register new user", "注册新用户" },
            { "RememberLogin", "记住登陆" },
            { "Register", "注册" },
            { "ConfirmPassword", "确认密码" },
            { "Please repeat the password exactly", "请重复前面填写的密码" },
            { "OldPassword", "原密码" },
            { "Please enter old password", "请填写原密码" },
            { "User Registration", "用户注册" },
            { "User Login", "用户登录" },
            { "Username is already taken, please choose other username", "用户名已经被使用，请选择其他用户名" },
            { "You have registered successfully, thanks for you registration", "注册用户成功，感谢您的注册" },
            { "User Panel", "用户中心" },
            { "Login successful", "登陆成功" },
            { "Welcome to ", "欢迎光临" },
            { "Logout", "退出登陆" },
            { "Register for free", "免费注册" },
            { "Website has no admin yet, the first login user will become super admin.",
                "当前没有任何管理员，第一次登录的用户将会成为超级管理员" },
            { "You have already logged in, continue will replace the logged in user.",
                "您已经登陆，继续登陆将会替换当前登录的用户" },
            { "Sorry, You have no privileges to use admin panel.", "抱歉，你没有使用管理后台的权限" },
            { "Incorrect username or password", "用户名或密码不正确，请重新填写" },
            { "Apps", "应用" },
            { "Workspace", "工作间" },
            { "Website Index", "网站首页" },
            { "About Me", "关于我" },
            { "About Website", "关于网站" },
            { "Admin Panel", "管理后台" },
            { "My Apps", "我的应用" },
            { "Action require {0}, and {1} privileges", "操作要求拥有{0}身份，且拥有{1}权限" },
            { "Action require {0}", "操作要求拥有{0}身份" },
            { "User", "用户" },
            { "UserType", "用户类型" },
            { "Admin", "管理员" },
            { "SuperAdmin", "超级管理员" },
            { "CooperationPartner", "合作伙伴" },
            { "CreateTime", "创建时间" },
            { "Admin Manage", "管理员管理" },
            { "User Manage", "用户管理" },
            { "Role Manage", "角色管理" },
            { "Role", "角色" },
            { "UserRole", "角色" },
            { "View", "查看" },
            { "Edit", "编辑" },
            { "Delete", "删除" },
            { "DeleteForever", "永久删除" },
            { "Please enter name", "请填写名称" },
            { "Remark", "备注" },
            { "Please enter remark", "请填写备注" },
            { "Saved Successfully", "保存成功" },
            { "Keep empty if you don't want to change", "如果不想修改，请保持空白" },
            { "Name/Remark", "名称/备注" },
            { "Name", "名称" },
            { "Value", "值" },
            { "DirectoryName", "目录名称" },
            { "Description", "描述" },
            { "LastUpdated", "更新时间" },
            { "Add {0}", "添加{0}" },
            { "Edit {0}", "编辑{0}" },
            { "Delete {0}", "删除{0}" },
            { "Please enter password when creating admin", "创建管理员时需要填写密码" },
            { "Please enter password when creating user", "创建用户时需要填写密码" },
            { "You can't downgrade yourself to normal admin", "不能取消自身的超级管理员权限" },
            { "Privileges", "权限" },
            { "Recycle Bin", "回收站" },
            { "Batch Delete", "批量删除" },
            { "Please select {0} to delete", "请选择需要删除的{0}" },
            { "Sure to delete following {0}?", "确认删除以下{0}？" },
            { "Batch Recover", "批量恢复" },
            { "Please select {0} to recover", "请选择需要恢复的{0}" },
            { "Sure to recover following {0}?", "确认恢复以下{0}？" },
            { "Batch Delete Forever", "批量永久删除" },
            { "Sure to delete following {0} forever?", "确认永久删除以下{0}？此操作将不可恢复！" },
            { "Delete yourself is not allowed", "不能删除你自身的用户" },
            { "Non ajax request batch action is not secure", "非Ajax提交的批量操作不安全，请修改相关代码" },
            { "Action {0} not exist", "找不到{0}对应的操作" },
            { "Delete Successful", "删除成功" },
            { "Batch Delete Successful", "批量删除成功" },
            { "Batch Recover Successful", "批量恢复成功" },
            { "Batch Delete Forever Successful", "批量永久删除成功" },
            { "Change Password", "修改密码" },
            { "Change Avatar", "修改头像" },
            { "Avatar", "头像" },
            { "DeleteAvatar", "删除头像" },
            { "Please select avatar file", "请选择头像图片" },
            { "Parse uploaded image failed", "解析上传的图片失败" },
            { "User not found", "用户不存在" },
            { "Incorrect old password", "原密码不正确，请重新填写" },
            { "No Role", "无角色" },
            { "Website Name", "网站名称" },
            { "Default Language", "默认语言" },
            { "Default Timezone", "默认时区" },
            { "Hosting Information", "服务器信息" },
            { "Plugin List", "插件列表" },
            { "Admin panel and users management", "提供管理后台和用户角色管理等功能" },
            { "Clear Cache", "清理缓存" },
            { "Clear Cache Successfully", "清理缓存成功" }
        };

        public bool CanTranslate(string code) {
            return _codes.Contains(code);
        }

        public string Translate(string text) {
            string find;
            if (!_translates.TryGetValue(text, out find)) {
                find = text;
            }
            return find;
        }
    }
}
